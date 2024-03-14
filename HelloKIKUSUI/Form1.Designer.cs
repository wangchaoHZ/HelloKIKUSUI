namespace HelloKIKUSUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLedBulb1 = new Sunny.UI.UILedBulb();
            this.uiipTextBox1 = new Sunny.UI.UIIPTextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLedBulb2 = new Sunny.UI.UILedBulb();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel1.Location = new System.Drawing.Point(345, 29);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(577, 49);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "KIKUSUI电源ModbusTCP协议转发终端";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel2.Location = new System.Drawing.Point(168, 796);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(971, 42);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "备注：Modbus TCP ->SCPI  电源设备IP地址:192.168.1.127 端口:5024";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(1040, 158);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(183, 56);
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "连接电源";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLedBulb1
            // 
            this.uiLedBulb1.Location = new System.Drawing.Point(1229, 171);
            this.uiLedBulb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiLedBulb1.Name = "uiLedBulb1";
            this.uiLedBulb1.Size = new System.Drawing.Size(52, 42);
            this.uiLedBulb1.TabIndex = 4;
            this.uiLedBulb1.Text = "uiLedBulb1";
            // 
            // uiipTextBox1
            // 
            this.uiipTextBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiipTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiipTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiipTextBox1.Location = new System.Drawing.Point(73, 158);
            this.uiipTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiipTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiipTextBox1.Name = "uiipTextBox1";
            this.uiipTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.uiipTextBox1.ShowText = false;
            this.uiipTextBox1.Size = new System.Drawing.Size(300, 56);
            this.uiipTextBox1.TabIndex = 6;
            this.uiipTextBox1.Text = "127.0.0.1";
            this.uiipTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiipTextBox1.Value = ((System.Net.IPAddress)(resources.GetObject("uiipTextBox1.Value")));
            this.uiipTextBox1.ValueChanged += new System.EventHandler(this.uiipTextBox1_ValueChanged);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.DoubleValue = 8888D;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiTextBox1.IntValue = 8888;
            this.uiTextBox1.Location = new System.Drawing.Point(407, 158);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 20);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(105, 56);
            this.uiTextBox1.TabIndex = 7;
            this.uiTextBox1.Text = "8888";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox1.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel5.Location = new System.Drawing.Point(402, 106);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(159, 45);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "端口";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel4.Location = new System.Drawing.Point(68, 106);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(244, 45);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "本机IP地址";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRichTextBox1.Location = new System.Drawing.Point(75, 250);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiRichTextBox1.ScrollBarStyleInherited = false;
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(1205, 540);
            this.uiRichTextBox1.TabIndex = 10;
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(757, 158);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(183, 56);
            this.uiButton2.TabIndex = 11;
            this.uiButton2.Text = "启动监听";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLedBulb2
            // 
            this.uiLedBulb2.Location = new System.Drawing.Point(948, 171);
            this.uiLedBulb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiLedBulb2.Name = "uiLedBulb2";
            this.uiLedBulb2.Size = new System.Drawing.Size(52, 42);
            this.uiLedBulb2.TabIndex = 12;
            this.uiLedBulb2.Text = "uiLedBulb2";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel3.Location = new System.Drawing.Point(569, 106);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(159, 45);
            this.uiLabel3.TabIndex = 14;
            this.uiLabel3.Text = "站号";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.DoubleValue = 100D;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiTextBox2.IntValue = 100;
            this.uiTextBox2.Location = new System.Drawing.Point(574, 158);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 20);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(105, 56);
            this.uiTextBox2.TabIndex = 13;
            this.uiTextBox2.Text = "100";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox2.Watermark = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 862);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiLedBulb2);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiRichTextBox1);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLedBulb1);
            this.Controls.Add(this.uiipTextBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private Sunny.UI.UIIPTextBox uiipTextBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILedBulb uiLedBulb2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox2;
    }
}

