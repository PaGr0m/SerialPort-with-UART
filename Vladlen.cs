using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

using System.IO.Ports;

namespace ChipAndNuts
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer aTimer;
        SerialPort SP1;
        int State;
        string stack;
        int counter;
        public Form1()
        {
            InitializeComponent();
            State = 0;
            SP1 = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            SP1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            stack = "";
            aTimer = new System.Timers.Timer(300);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.AutoReset = true;
            //aTimer.Start(); 
            counter = 0;

            dataGridView1.Rows.Add("55aa", "ВВС", "Fantom", "15.08.2016");
            dataGridView1.Rows[0].Cells[4].Style.BackColor = System.Drawing.Color.Red;

        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            ////MessageBox.Show("asdasd"); 
            //if (stack == "") return; 
            ////listBox1.Items.Add("---------— " + stack); 
            //if (stack == "CE") 
            //{ 
            // State = 0; 
            // listBox1.Items.Add("Error Connection - " + stack); 
            //} 
            //else 
            //{ 
            // listBox1.Items.Add("MAV #" + stack + " in range. Time "+DateTime.Now); 
            // State = 0; 
            //} 
            //stack = ""; 
            //listBox1.SelectedIndex = listBox1.Items.Count - 1; 
            ////aTimer.Stop(); 
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string data = SP1.ReadLine(); 
            //listBox1.Items.Add("RECV: "+data); 
            //this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data }); 
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //listBox1.Items.Add("RECV: " + indata); 
            //MessageBox.Show(indata); 
            if (aTimer.Enabled == true)
            {
                stack += indata;
            }
            else
            {
                stack += indata;
                //aTimer.Start(); 
                //listBox1.Items.Add("START " + stack); 
            }


            //if (indata[0] == 'C') State = 0; 
        }

        private void ScanPort(object sender, EventArgs e)
        {
            SP1.Close();
            string[] myPort;
            myPort = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(myPort);
        }

        private void Connect(object sender, EventArgs e)
        {
            SP1.PortName = comboBox1.Text.ToString();
            SP1.Handshake = Handshake.None;
            if (SP1.IsOpen == false)
            {
                SP1.Open();
                listBox1.Items.Add("Порт открыт");
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void ProgramEnd(object sender, FormClosingEventArgs e)
        {
            if (SP1.IsOpen == true)
            {
                SP1.Close();
                listBox1.Items.Add("Порт закрыт");
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (SP1.IsOpen == true)
            {
                byte[] z = { 0xfa };
                SP1.Write(z, 0, 1);
                listBox1.Items.Add("SEND: " + "0xfa");
                timer1.Interval = 500;

                //switch (State) 
                //{ 
                // case 0: 
                // { 
                // byte[] z = { 0x00 }; 
                // SP1.Write(z, 0, 1); 
                // //listBox1.Items.Add("SEND: " + "0x00"); 
                // State = 1; 
                // timer1.Interval = 300; 
                // break; 
                // } 
                // case 1: 
                // { 
                // byte[] z ={0x55}; 
                // SP1.Write(z, 0, 1); 
                // //listBox1.Items.Add("SEND: " + "0x55"); 
                // State = 2; 
                // break; 
                // } 
                // case 2: 
                // { 
                // byte[] z = { 0xff }; 
                // SP1.Write(z, 0, 1); 
                // //listBox1.Items.Add("SEND: " + "0xff"); 
                // State = 3; 
                // break; 
                // } 
                // case 3: 
                // { 
                // byte[] z = { 0xaa }; 
                // SP1.Write(z, 0, 1); 
                // //listBox1.Items.Add("SEND: " + "0xaa"); 
                // State = 4; 
                // break; 
                // } 
                // case 4: 
                // { 
                // byte[] z = { 0x00 }; 
                // SP1.Write(z, 0, 1); 
                // //listBox1.Items.Add("SEND: " + "0x00"); 
                // State = 0; 
                // timer1.Interval = 1000; 
                // //stack = ""; 
                // break; 
                // } 
                //}; 
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void DebugTimer(object sender, EventArgs e)
        {
            if (stack == "") return;
            //listBox1.Items.Add("---------— " + stack); 
            if (stack == "CE")
            {
                State = 0;
                listBox1.Items.Add("Error Connection - " + stack);
                dataGridView1.Rows[0].Cells[4].Style.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                listBox1.Items.Add("MAV #" + stack + " in range. Time " + DateTime.Now);
                dataGridView1.Rows[0].Cells[4].Style.BackColor = System.Drawing.Color.Green;
                State = 0;
            }
            stack = "";
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            //aTimer.Stop(); 

            //if (stack == "CE") 
            //{ 
            // State = 0; 
            // listBox1.Items.Add("Error Connection - " + stack); 
            //} 
            //else if (stack!="CE" && stack!="") 
            //{ 
            // listBox1.Items.Add("MAV #" + stack + " in range. Time " + DateTime.Now); 
            // State = 0; 
            //} 
            //if (stack == "55aa") 
            //{ 
            // counter = 14; 
            //} 
            //else 
            //{ 
            // counter--; 
            //} 
            //if (counter>0) 
            //{ 
            // dataGridView1.Rows[0].Cells[4].Style.BackColor = System.Drawing.Color.Green; 
            //} 
            //else 
            //{ 
            // dataGridView1.Rows[0].Cells[4].Style.BackColor = System.Drawing.Color.Red; 
            //} 
            //stack = ""; 
            //listBox1.SelectedIndex = listBox1.Items.Count - 1; 
        }

    }
}
