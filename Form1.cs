using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPort_test
{
    public partial class Form1 : Form
    {
        //跨线程操作控件会引起异常  (接收数据是新开线程 窗口的接收文本框控件在主线程)  
        //两个解决方案任选其一
        //解决方案一：
        protected delegate void UpdateDisplayDelegate(string text, TextBox textBox);//新建委托 来显示接收内容

        public Form1()
        {
            InitializeComponent();

            serialPort1.Encoding = Encoding.GetEncoding("GB2312");   //串口编码引入GB2312编码(汉字编码)
            //解决方案二：
            //Control.CheckForIllegalCrossThreadCalls = false;   //取消跨线程检查

            ReflashPortToComboBox(serialPort1,combox_port);  //自动扫描可用串口并添加到串口号列表上
        }

        //窗体加载函数
        private void Form1_Load(object sender, EventArgs e)
        {
            combox_port.SelectedIndex = 0;//默认串口为最小COM
            combox_baud.SelectedIndex = 0;//默认波特率为9600
            combox_data.SelectedIndex = 3;//默认数据位8
            combox_check.SelectedIndex = 0;//默认校验位None
            combox_stop.SelectedIndex = 0;//默认停止位1
        }

        //自动扫描可用串口并添加到串口号列表上
        private void ReflashPortToComboBox(SerialPort serialPort,ComboBox comboBox)
        {                                                               //将可用端口号添加到ComboBox
            if (!serialPort.IsOpen)//串口处于关闭状态
            {
                comboBox.Items.Clear();
                string[] str = SerialPort.GetPortNames();
                if (str == null)
                {
                    MessageBox.Show("本机没有串口！", "Error");
                    return;
                }
                //添加串口
                foreach (string s in str)
                {
                    comboBox.Items.Add(s);
                    Console.WriteLine(s);
                }
            }
            else
            {
                MessageBox.Show("串口处于打开状态不能刷新串口列表", "Error");
            }
        }

        public void UpdateDisplayToTextBox(string text, TextBox textBox)
        {
            //Console.WriteLine("接受到的数据为：" + text);//测试用
            
            textBox.AppendText(text);
            if (radioBt_getHex.Checked)
                textBox.AppendText("\r\n");//如果hex接收 则自动加回车
        }

        //串口接收数据触发事件
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if (radioBt_getAscii.Checked)  //如果接收是字符模式
                {
                    string content = serialPort1.ReadExisting();
                    //text_receive.AppendText(content);
                    Invoke(new UpdateDisplayDelegate(UpdateDisplayToTextBox), new object[] { content, text_receive });
                }
                else
                {
                    byte[] ReDatas = new byte[serialPort1.BytesToRead];
                    serialPort1.Read(ReDatas, 0, ReDatas.Length);//读取数据
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < ReDatas.Length; i++)
                    {
                        stringBuilder.AppendFormat("{0:x2}" + " ", ReDatas[i]);//格式化数据
                    }
                    string content = stringBuilder.ToString().ToUpper();
                    Invoke(new UpdateDisplayDelegate(UpdateDisplayToTextBox), new object[] { content, text_receive });
                }
            }
            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message, "接收数据异常提示");
            }
        }

        //串口打开按钮点击触发事件
        private void bt_open_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)//串口处于关闭状态
            {
                try
                {
                    string strSerialName = combox_port.SelectedItem.ToString();
                    string strBaudRate = combox_baud.SelectedItem.ToString();
                    string strDataBit = combox_data.SelectedItem.ToString();
                    string strCheckBit = combox_check.SelectedItem.ToString();
                    string strStopBit = combox_stop.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDataBit = Convert.ToInt32(strDataBit);

                    serialPort1.PortName = strSerialName;//串口号
                    serialPort1.BaudRate = iBaudRate;//波特率
                    serialPort1.DataBits = iDataBit;//数据位

                    switch (strStopBit)            //停止位
                    {
                        case "1":
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：停止位参数不正确!", "Error");
                            break;
                    }
                    switch (strCheckBit)             //校验位
                    {
                        case "None":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：校验位参数不正确!", "Error");
                            break;
                    }

                    //打开串口
                    serialPort1.Open();

                    //打开串口后设置将不可更改
                    combox_port.Enabled = false;
                    combox_baud.Enabled = false;
                    combox_data.Enabled = false;
                    combox_check.Enabled = false;
                    combox_stop.Enabled = false;

                    //打开串口后发送接受设置不可更改
                    radioBt_getAscii.Enabled = false;
                    radioBt_getHex.Enabled = false;
                    radioBt_sendAscii.Enabled = false;
                    radioBt_sendHex.Enabled = false;

                    //关闭打开相应按钮
                    bt_send.Enabled = true;
                    bt_close.Enabled = true;
                    bt_open.Enabled = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口已经打开", "Error");
                return;
            }
        }

        //串口关闭按钮点击触发事件
        private void bt_close_Click(object sender, EventArgs e)
        {
            serialPort1.Close();//关闭串口

            //关闭串口后设置恢复可修改
            combox_port.Enabled = true;
            combox_baud.Enabled = true;
            combox_data.Enabled = true;
            combox_check.Enabled = true;
            combox_stop.Enabled = true;

            //关闭串口后发送接受设置恢复可修改
            radioBt_getAscii.Enabled = true;
            radioBt_getHex.Enabled = true;
            radioBt_sendAscii.Enabled = true;
            radioBt_sendHex.Enabled = true;


            //关闭打开相应按钮
            bt_send.Enabled = false;
            bt_close.Enabled = false;
            bt_open.Enabled = true;
        }

        //串口发送按钮点击触发事件
        private void bt_send_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1];//存放数字字节
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                if (text_send.Text != "")//判断发送窗是否有数据
                {
                    if (radioBt_sendAscii.Checked == true)//如果发送模式是字符模式
                        try
                        {
                            serialPort1.Write(text_send.Text);//发送数据
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "串口数据写入错误");//出错提示
                            serialPort1.Close();
                            bt_open.Enabled = true;//打开串口按钮可用
                            bt_close.Enabled = false;//关闭串口按钮不可用
                        }
                    else if (radioBt_sendHex.Checked == true)//如果发送模式是HEX模式
                    {
                        try
                        {
                            string sendString=text_send.Text;
                            sendString = sendString.Replace(" ", "");
                            if ((sendString.Length % 2) != 0)
                                sendString += " ";
                            byte[] sendBytes = new byte[sendString.Length / 2];
                            for (int i = 0; i < sendBytes.Length; i++)
                                sendBytes[i] = Convert.ToByte(sendString.Substring(i * 2, 2).Replace(" ", ""), 16);
                            serialPort1.Write(sendBytes, 0, sendBytes.Length);//发送数据
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "串口数据写入错误");//出错提示
                            serialPort1.Close();
                            bt_open.Enabled = true;//打开串口按钮可用
                            bt_close.Enabled = false;//关闭串口按钮不可用
                        }
                    }
                }
            }
        }

        //清空接收窗按钮点击触发事件
        private void bt_clear_receive_Click(object sender, EventArgs e)
        {
            text_receive.Clear();
        }

        //清空发送窗按钮点击触发事件
        private void bt_clear_send_Click(object sender, EventArgs e)
        {
            text_send.Clear();
            string abc = "abc\r\n";
            byte[] ReDatas = new byte[abc.Length];
            Console.WriteLine(abc.Length);
            ReDatas = System.Text.Encoding.Default.GetBytes(abc);
            
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ReDatas.Length; i++)
            {
                stringBuilder.AppendFormat("{0:x2}" + " ", ReDatas[i]);//格式化数据
            }
            string content = stringBuilder.ToString().ToUpper();
            Console.WriteLine(content);
            Invoke(new UpdateDisplayDelegate(UpdateDisplayToTextBox), new object[] { content, text_receive });
        }

        //刷新端口号按钮点击触发事件
        private void bt_reflashPort_Click(object sender, EventArgs e)
        {
            ReflashPortToComboBox(serialPort1,combox_port);
        }


    }
}
