using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;//SerialPort 命名空间
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort_bilibili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Encoding = Encoding.GetEncoding("GB2312");   //串口编码引入GB2312编码(汉字编码)
            //防止跨线程操作空间异常
            Control.CheckForIllegalCrossThreadCalls = false;   //取消跨线程检查
        }

        //端口号扫描按钮
        private void button1_Click(object sender, EventArgs e)
        {
            ReflashPortToComboBox(serialPort1, comboBox_port);
        }

        //自动扫描可用串口并添加到串口号列表上
        private void ReflashPortToComboBox(SerialPort serialPort, ComboBox comboBox)
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

        //窗体加载函数
        private void Form1_Load(object sender, EventArgs e)
        {
            ReflashPortToComboBox(serialPort1, comboBox_port);//第一次加载时候就预先扫描一次串口号
            button_close.Enabled = false;//关闭串口按钮按钮使能
        }

        //串口打开按钮
        private void button_open_Click(object sender, EventArgs e)
        {
            Int32 iBaudRate = Convert.ToInt32(comboBox_BaudRate.SelectedItem.ToString());//获取波特率下拉框里选中的波特率数据从字符串转为int32

            serialPort1.PortName = comboBox_port.SelectedItem.ToString();//串口号
            serialPort1.BaudRate = iBaudRate;//波特率

            try
            {
                serialPort1.Open();
                button_open.Enabled = false;
                button_close.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("串口打开失败" + ex, "error");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                button_open.Enabled = true;
                button_close.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口关闭失败" + ex, "error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_get.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_send.Clear();
        }

        //串口数据接受事件
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (radioBt_getAscii.Checked)  //如果接收是字符模式
                {
                    string content = serialPort1.ReadExisting();//从串口控件读取输入流返回为string
                    textBox_get.AppendText(content);//将接受到的string数据添加到接收窗
                }
                else //如果接收是HEX模式
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据接受出错" + ex, "error");
            }
        }

        //发送数据按钮
        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                if (textBox_send.Text != "")//判断发送窗是否有数据
                {
                    if (radioBt_sendAscii.Checked == true)//如果发送模式是字符模式
                        try
                        {
                            serialPort1.Write(textBox_send.Text);//发送数据
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "串口数据写入错误");//出错提示
                            serialPort1.Close();
                            button_open.Enabled = true;//打开串口按钮可用
                            button_close.Enabled = false;//关闭串口按钮不可用
                        }
                    else//如果发送模式是HEX模式
                    {

                    }
                }
            }
        }
    }
}
