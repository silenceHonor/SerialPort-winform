namespace SerialPort_bilibili
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBt_getHEX = new System.Windows.Forms.RadioButton();
            this.radioBt_getAscii = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.radioBt_sendAscii = new System.Windows.Forms.RadioButton();
            this.radioBt_sendHEX = new System.Windows.Forms.RadioButton();
            this.textBox_get = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.comboBox_port);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "端口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(67, 33);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(106, 20);
            this.comboBox_port.TabIndex = 1;
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(67, 59);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(106, 20);
            this.comboBox_BaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "波特率";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(17, 91);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "打开串口";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(98, 91);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "关闭串口";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.radioBt_getAscii);
            this.groupBox2.Controls.Add(this.radioBt_getHEX);
            this.groupBox2.Location = new System.Drawing.Point(16, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // radioBt_getHEX
            // 
            this.radioBt_getHEX.AutoSize = true;
            this.radioBt_getHEX.Location = new System.Drawing.Point(7, 21);
            this.radioBt_getHEX.Name = "radioBt_getHEX";
            this.radioBt_getHEX.Size = new System.Drawing.Size(41, 16);
            this.radioBt_getHEX.TabIndex = 0;
            this.radioBt_getHEX.TabStop = true;
            this.radioBt_getHEX.Text = "HEX";
            this.radioBt_getHEX.UseVisualStyleBackColor = true;
            // 
            // radioBt_getAscii
            // 
            this.radioBt_getAscii.AutoSize = true;
            this.radioBt_getAscii.Location = new System.Drawing.Point(54, 21);
            this.radioBt_getAscii.Name = "radioBt_getAscii";
            this.radioBt_getAscii.Size = new System.Drawing.Size(53, 16);
            this.radioBt_getAscii.TabIndex = 1;
            this.radioBt_getAscii.TabStop = true;
            this.radioBt_getAscii.Text = "ASCII";
            this.radioBt_getAscii.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "清空接受窗口";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.radioBt_sendAscii);
            this.groupBox3.Controls.Add(this.radioBt_sendHEX);
            this.groupBox3.Location = new System.Drawing.Point(16, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 49);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(113, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "清空发送窗口";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioBt_sendAscii
            // 
            this.radioBt_sendAscii.AutoSize = true;
            this.radioBt_sendAscii.Location = new System.Drawing.Point(54, 21);
            this.radioBt_sendAscii.Name = "radioBt_sendAscii";
            this.radioBt_sendAscii.Size = new System.Drawing.Size(53, 16);
            this.radioBt_sendAscii.TabIndex = 1;
            this.radioBt_sendAscii.TabStop = true;
            this.radioBt_sendAscii.Text = "ASCII";
            this.radioBt_sendAscii.UseVisualStyleBackColor = true;
            // 
            // radioBt_sendHEX
            // 
            this.radioBt_sendHEX.AutoSize = true;
            this.radioBt_sendHEX.Location = new System.Drawing.Point(7, 21);
            this.radioBt_sendHEX.Name = "radioBt_sendHEX";
            this.radioBt_sendHEX.Size = new System.Drawing.Size(41, 16);
            this.radioBt_sendHEX.TabIndex = 0;
            this.radioBt_sendHEX.TabStop = true;
            this.radioBt_sendHEX.Text = "HEX";
            this.radioBt_sendHEX.UseVisualStyleBackColor = true;
            // 
            // textBox_get
            // 
            this.textBox_get.Location = new System.Drawing.Point(235, 12);
            this.textBox_get.Multiline = true;
            this.textBox_get.Name = "textBox_get";
            this.textBox_get.Size = new System.Drawing.Size(248, 183);
            this.textBox_get.TabIndex = 4;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(235, 201);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(187, 49);
            this.textBox_send.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "发送";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 266);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_get);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioBt_getAscii;
        private System.Windows.Forms.RadioButton radioBt_getHEX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioBt_sendAscii;
        private System.Windows.Forms.RadioButton radioBt_sendHEX;
        private System.Windows.Forms.TextBox textBox_get;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button6;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

