namespace SerialPort_test
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bt_send = new System.Windows.Forms.Button();
            this.text_send = new System.Windows.Forms.TextBox();
            this.text_receive = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBt_sendAscii = new System.Windows.Forms.RadioButton();
            this.radioBt_sendHex = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBt_getAscii = new System.Windows.Forms.RadioButton();
            this.radioBt_getHex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_reflash = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.combox_stop = new System.Windows.Forms.ComboBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.combox_port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combox_check = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_baud = new System.Windows.Forms.ComboBox();
            this.combox_data = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_clear_send = new System.Windows.Forms.Button();
            this.bt_clear_receive = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(584, 380);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(61, 44);
            this.bt_send.TabIndex = 11;
            this.bt_send.Text = "发送";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // text_send
            // 
            this.text_send.Location = new System.Drawing.Point(265, 380);
            this.text_send.Multiline = true;
            this.text_send.Name = "text_send";
            this.text_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_send.Size = new System.Drawing.Size(313, 44);
            this.text_send.TabIndex = 10;
            // 
            // text_receive
            // 
            this.text_receive.Location = new System.Drawing.Point(265, 12);
            this.text_receive.Multiline = true;
            this.text_receive.Name = "text_receive";
            this.text_receive.ReadOnly = true;
            this.text_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_receive.Size = new System.Drawing.Size(380, 333);
            this.text_receive.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_clear_send);
            this.groupBox3.Controls.Add(this.radioBt_sendAscii);
            this.groupBox3.Controls.Add(this.radioBt_sendHex);
            this.groupBox3.Location = new System.Drawing.Point(16, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 61);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // radioBt_sendAscii
            // 
            this.radioBt_sendAscii.AutoSize = true;
            this.radioBt_sendAscii.Checked = true;
            this.radioBt_sendAscii.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBt_sendAscii.Location = new System.Drawing.Point(65, 27);
            this.radioBt_sendAscii.Name = "radioBt_sendAscii";
            this.radioBt_sendAscii.Size = new System.Drawing.Size(66, 20);
            this.radioBt_sendAscii.TabIndex = 6;
            this.radioBt_sendAscii.TabStop = true;
            this.radioBt_sendAscii.Text = "ASCII";
            this.radioBt_sendAscii.UseVisualStyleBackColor = true;
            // 
            // radioBt_sendHex
            // 
            this.radioBt_sendHex.AutoSize = true;
            this.radioBt_sendHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBt_sendHex.Location = new System.Drawing.Point(9, 27);
            this.radioBt_sendHex.Name = "radioBt_sendHex";
            this.radioBt_sendHex.Size = new System.Drawing.Size(50, 20);
            this.radioBt_sendHex.TabIndex = 5;
            this.radioBt_sendHex.Text = "HEX";
            this.radioBt_sendHex.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_clear_receive);
            this.groupBox2.Controls.Add(this.radioBt_getAscii);
            this.groupBox2.Controls.Add(this.radioBt_getHex);
            this.groupBox2.Location = new System.Drawing.Point(16, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接受设置";
            // 
            // radioBt_getAscii
            // 
            this.radioBt_getAscii.AutoSize = true;
            this.radioBt_getAscii.Checked = true;
            this.radioBt_getAscii.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBt_getAscii.Location = new System.Drawing.Point(65, 30);
            this.radioBt_getAscii.Name = "radioBt_getAscii";
            this.radioBt_getAscii.Size = new System.Drawing.Size(66, 20);
            this.radioBt_getAscii.TabIndex = 4;
            this.radioBt_getAscii.TabStop = true;
            this.radioBt_getAscii.Text = "ASCII";
            this.radioBt_getAscii.UseVisualStyleBackColor = true;
            // 
            // radioBt_getHex
            // 
            this.radioBt_getHex.AutoSize = true;
            this.radioBt_getHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBt_getHex.Location = new System.Drawing.Point(9, 30);
            this.radioBt_getHex.Name = "radioBt_getHex";
            this.radioBt_getHex.Size = new System.Drawing.Size(50, 20);
            this.radioBt_getHex.TabIndex = 3;
            this.radioBt_getHex.Text = "HEX";
            this.radioBt_getHex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_reflash);
            this.groupBox1.Controls.Add(this.bt_close);
            this.groupBox1.Controls.Add(this.combox_stop);
            this.groupBox1.Controls.Add(this.bt_open);
            this.groupBox1.Controls.Add(this.combox_port);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combox_check);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combox_baud);
            this.groupBox1.Controls.Add(this.combox_data);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // bt_reflash
            // 
            this.bt_reflash.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_reflash.Location = new System.Drawing.Point(15, 23);
            this.bt_reflash.Name = "bt_reflash";
            this.bt_reflash.Size = new System.Drawing.Size(65, 27);
            this.bt_reflash.TabIndex = 6;
            this.bt_reflash.Text = "端口";
            this.bt_reflash.UseVisualStyleBackColor = true;
            this.bt_reflash.Click += new System.EventHandler(this.bt_reflashPort_Click);
            // 
            // bt_close
            // 
            this.bt_close.Enabled = false;
            this.bt_close.Location = new System.Drawing.Point(132, 204);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "关闭串口";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // combox_stop
            // 
            this.combox_stop.FormattingEnabled = true;
            this.combox_stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.combox_stop.Location = new System.Drawing.Point(86, 167);
            this.combox_stop.Name = "combox_stop";
            this.combox_stop.Size = new System.Drawing.Size(121, 20);
            this.combox_stop.TabIndex = 10;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(15, 204);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(75, 23);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "打开串口";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // combox_port
            // 
            this.combox_port.FormattingEnabled = true;
            this.combox_port.Location = new System.Drawing.Point(86, 26);
            this.combox_port.Name = "combox_port";
            this.combox_port.Size = new System.Drawing.Size(121, 20);
            this.combox_port.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // combox_check
            // 
            this.combox_check.FormattingEnabled = true;
            this.combox_check.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mask",
            "Space"});
            this.combox_check.Location = new System.Drawing.Point(86, 132);
            this.combox_check.Name = "combox_check";
            this.combox_check.Size = new System.Drawing.Size(121, 20);
            this.combox_check.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "校验位";
            // 
            // combox_baud
            // 
            this.combox_baud.FormattingEnabled = true;
            this.combox_baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.combox_baud.Location = new System.Drawing.Point(86, 62);
            this.combox_baud.Name = "combox_baud";
            this.combox_baud.Size = new System.Drawing.Size(121, 20);
            this.combox_baud.TabIndex = 4;
            // 
            // combox_data
            // 
            this.combox_data.FormattingEnabled = true;
            this.combox_data.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.combox_data.Location = new System.Drawing.Point(86, 97);
            this.combox_data.Name = "combox_data";
            this.combox_data.Size = new System.Drawing.Size(121, 20);
            this.combox_data.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据位";
            // 
            // bt_clear_send
            // 
            this.bt_clear_send.Location = new System.Drawing.Point(137, 17);
            this.bt_clear_send.Name = "bt_clear_send";
            this.bt_clear_send.Size = new System.Drawing.Size(76, 38);
            this.bt_clear_send.TabIndex = 12;
            this.bt_clear_send.Text = "清空发送窗";
            this.bt_clear_send.UseVisualStyleBackColor = true;
            this.bt_clear_send.Click += new System.EventHandler(this.bt_clear_send_Click);
            // 
            // bt_clear_receive
            // 
            this.bt_clear_receive.Location = new System.Drawing.Point(137, 20);
            this.bt_clear_receive.Name = "bt_clear_receive";
            this.bt_clear_receive.Size = new System.Drawing.Size(76, 38);
            this.bt_clear_receive.TabIndex = 13;
            this.bt_clear_receive.Text = "清空接受窗";
            this.bt_clear_receive.UseVisualStyleBackColor = true;
            this.bt_clear_receive.Click += new System.EventHandler(this.bt_clear_receive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.text_send);
            this.Controls.Add(this.text_receive);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox text_send;
        private System.Windows.Forms.TextBox text_receive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_clear_send;
        private System.Windows.Forms.RadioButton radioBt_sendAscii;
        private System.Windows.Forms.RadioButton radioBt_sendHex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_clear_receive;
        private System.Windows.Forms.RadioButton radioBt_getAscii;
        private System.Windows.Forms.RadioButton radioBt_getHex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_reflash;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ComboBox combox_stop;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.ComboBox combox_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combox_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combox_baud;
        private System.Windows.Forms.ComboBox combox_data;
        private System.Windows.Forms.Label label3;
    }
}

