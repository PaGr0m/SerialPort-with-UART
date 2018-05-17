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
using System.Timers;

namespace Network_Network
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = new SerialPort();
        private System.Timers.Timer timer;

        string stack = "";

        public Form1()
        {
            InitializeComponent();

            SearchPorts();
            AddItemsToBoxes();
        }

        private void SearchPorts()
        {
            comboBoxPortsName.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPortsName.Items.Add(port);
            }
        }

        private void ConnectPort()
        {
            Console.Write(comboBoxPortsName.Text, comboBoxBaudrate.Text);

            serialPort.PortName = comboBoxPortsName.Text;
            serialPort.BaudRate = int.Parse(comboBoxBaudrate.Text.ToString());

            if (serialPort.IsOpen == false)
            {
                serialPort.DataReceived += new SerialDataReceivedEventHandler(ReadPort);

                //timer = new System.Timers.Timer(300);
                //timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                //timer.AutoReset = true;
                //timer.Start();

                serialPort.Open();
                PrintToPortStatus("Port is OPEN");
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

        }

        private void DisconnectPort()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                PrintToPortStatus("Port is CLOSE");
            }
        }

        void ReadPort(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadExisting();

            stack += data;


            //byte[] buffer = new byte[serialPort.ReadBufferSize];
            //int bytesRead = serialPort.Read(buffer, 0, buffer.Length);

            //string textRead = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            //PrintToPortConsole(textRead);
        }

        private void WritePort()
        {
            string textToSend = textBoxWrite.Text + "\r" + "\n";
            serialPort.Write(textToSend);

            //byte[] bytes = this.encoding.GetBytes(textToSend);
            //this.internalSerialStream.Write(bytes, 0, bytes.Length, this.writeTimeout);
        }

        private void AddItemsToBoxes()
        {
            comboBoxBaudrate.Items.Add("9600");
            comboBoxBaudrate.Items.Add("115200");
        }

        private void PrintToPortConsole(string text)
        {
            PortConsole.Text += text;
        }

        private void PrintToPortStatus(string status)
        {
            listBoxStatus.Items.Clear();
            listBoxStatus.Items.Add(status);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchPorts();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectPort();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            DisconnectPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WritePort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PortConsole.Items.Clear();
            //ReadPort();
        }

        private void timerPort_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                if (stack != "" && stack != "\n")
                {
                    int idx = stack.IndexOf('\n');
                    Console.Write(stack + '\n');
                    //Console.Write(idx);

                    if (idx != -1)
                    {
                        string cutStr = stack.Substring(0, idx+1);
                        stack = stack.Remove(0, idx+1);

                        PrintToPortConsole(cutStr);
                        //Console.Write(cutStr);
                    }
                }
            }
        }
    }
}
