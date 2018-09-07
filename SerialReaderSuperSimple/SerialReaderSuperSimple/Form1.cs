using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialReaderSuperSimple
{
    public partial class FormSerialReader : Form
    {
        public FormSerialReader()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
                ButtonConnect.Text = "Connect";
            }
            else
            {
                SerialPort.Open();
                ButtonConnect.Text = "Disconnect";
            }

        }

        private void ListComPort_MouseClick(object sender, MouseEventArgs e)
        {
            ListComPort.Items.Clear();
            //ToArray() seems redundant given GetPortNames returns string[]
            ListComPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            //test stuff
            //ListComPort.Items.Add("COM1");
            //ListComPort.Items.Add("COM2");
            //ListComPort.Items.Add("COM3");
        }

        private void FormSerialReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void ListComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SerialPort.Close();
            //ButtonConnect.Text = "Connect";
            //Console.WriteLine("Closed previous serial port");
            //SerialPort.PortName = ListComPort.Text;
        }
    }
}
