using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.ModBus;

using NModbus;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

using System.IO;


namespace HelloKIKUSUI
{
    public partial class Form1 : Form
    {

        int transValue = 0;
        int lastTransValue = 0;
        bool isStartListenAsync = false;
        bool isStartPower = false;

        TcpClient KiKuSuiTcpClient = null;
        NetworkStream KiKuSuiNetStream;
        private string KiKuSuiWebServerAddress = "192.168.1.127";
        private int KiKuSuiWebServerPort = 5024;

        
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            uiRichTextBox1.SelectionStart = uiRichTextBox1.TextLength;
            uiRichTextBox1.SelectionLength = 0;
        }

        private void uiMarkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uiLedBulb1.Color = Color.FromArgb(255, 99, 71);
            uiLedBulb2.Color = Color.FromArgb(255, 99, 71);
        }

        private void uiipTextBox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiButton2.Text == "启动监听")
                {
                    isStartListenAsync = true;
                    uiLedBulb2.Color = Color.FromArgb(192, 255, 192); 
                    uiButton2.Text = "停止监听";

                    //Modbus thread
                    Thread thread = new Thread(new ThreadStart(StartModbusTcpSlave));
                    thread.IsBackground = true;
                    thread.Start();
                }
                else if(uiButton2.Text == "停止监听")
                {
                    isStartListenAsync = false;
                    uiLedBulb2.Color = Color.FromArgb(255, 99, 71); 
                    uiButton2.Text = "启动监听";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void StartModbusTcpSlave()
        {
            IPAddress address = new IPAddress(new byte[] { 127, 0, 0, 1 });

            string[] addr = uiipTextBox1.Text.Split('.');

            if (addr.Length == 4)
            {
                address = new IPAddress(new byte[] { byte.Parse(addr[0]), byte.Parse(addr[1]), byte.Parse(addr[2]), byte.Parse(addr[3])});
            }

            // create and start the TCP slave
            int portNumber = int.Parse(uiTextBox1.Text);
            TcpListener slaveTcpListener = new TcpListener(address, portNumber);
            slaveTcpListener.Start();

            IModbusFactory factory = new ModbusFactory();
            IModbusSlaveNetwork network = factory.CreateSlaveNetwork(slaveTcpListener);

            int stationNumber = int.Parse(uiTextBox2.Text);
            IModbusSlave slave = factory.CreateSlave((byte)stationNumber);

            network.AddSlave(slave);
            network.ListenAsync();

            uiRichTextBox1.Text += "ModBusTCP启动监听线程\n";
            uiRichTextBox1.Text += "IP地址:"+ uiipTextBox1.Text+ " 端口:" + uiTextBox1.Text +'\n' ;
            uiRichTextBox1.Text += "站地址:"+ uiTextBox2.Text + '\n';

            while (isStartListenAsync)
            {
                Thread.Sleep(50);
                ushort[] data = slave.DataStore.HoldingRegisters.ReadPoints(0, 2);
                
                transValue = ((int)data[0] | (int)data[1] << 16);

                if(lastTransValue!=transValue)
                {
                    lastTransValue = transValue;
                    uiRichTextBox1.Text += "ModbusTCP接收数据:" + transValue.ToString() + '\n';
                    if (isStartPower)
                    {
                        float voltage = (float)(transValue / 10.0);
                        string voltageString = voltage.ToString("0.0");
                        uiRichTextBox1.Text += "电源输出设置:" + voltageString + "Vdc\n";
                        string message = "VOLT:OFFS "+ voltageString + "\n";
                        byte[] power = Encoding.ASCII.GetBytes(message);
                        KiKuSuiNetStream.Write(power, 0, power.Length);
                        Thread.Sleep(50);
                    }
                    else
                    {
                       UIMessageBox.Show("未连接电源");
                    }
                }
            }

            slaveTcpListener.Stop();
            network.Dispose();
            uiRichTextBox1.Text += "ModBusTCP退出监听线程\n";
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if(uiButton1.Text=="连接电源")
            {
                uiButton1.Text = "断开电源";
                KiKuSuiTcpClient = new TcpClient();
                KiKuSuiTcpClient.Connect(KiKuSuiWebServerAddress, KiKuSuiWebServerPort);
                KiKuSuiNetStream = KiKuSuiTcpClient.GetStream();

                string  message = "OUTP ON\n";
                byte[]  data = Encoding.ASCII.GetBytes(message);
                KiKuSuiNetStream.Write(data, 0, data.Length);
                Thread.Sleep(50);

                message = "VOLT:OFFS 0\n";
                data = Encoding.ASCII.GetBytes(message);
                KiKuSuiNetStream.Write(data, 0, data.Length);
                Thread.Sleep(50);
                isStartPower = true;
                uiRichTextBox1.Text += "电源已连接\n";
                uiLedBulb1.Color = Color.FromArgb(192, 255, 192);
            }
            else
            {
                uiButton1.Text = "连接电源";

                isStartPower = false;

                uiLedBulb1.Color = Color.FromArgb(255, 99, 71);

                string message = "OUTP OFF\n";
                byte[] data = Encoding.ASCII.GetBytes(message);
                KiKuSuiNetStream.Write(data, 0, data.Length);
                Thread.Sleep(50);

                message = "VOLT:OFFS 0\n";
                data = Encoding.ASCII.GetBytes(message);
                Console.WriteLine(data.Length);
                KiKuSuiNetStream.Write(data, 0, data.Length);
                Thread.Sleep(50);
             
                KiKuSuiTcpClient.Close();
                
                uiRichTextBox1.Text += "电源已断开\n";
            }
        }
    }
}
