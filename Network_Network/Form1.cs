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

namespace Network_Network
{
    public partial class Form1 : Form
    {
        private string PORT_NAME;

        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            SearchPorts();
        }

        private void SearchPorts()
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPortsName.Items.Add(port);
            }
        }

        private void ConnectPort()
        {
            serialPort.PortName = comboBoxPortsName.Text;
            listView1.Items.Add(serialPort.PortName);
        }

        private void DisconnectPort()
        {

        }

        private void ReadPort()
        {

        }

        private void WritePort()
        {

        }


        private void myFi(object sender, EventArgs e)
        {
            ConnectPort();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchPorts();
        }
    }
}
