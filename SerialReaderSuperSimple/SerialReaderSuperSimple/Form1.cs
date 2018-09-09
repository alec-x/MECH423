using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace SerialReaderSuperSimple
{
    public partial class FormSerialReader : Form
    {
        //Form variable
        ConcurrentQueue<int> serialReadQueue;
        

        public FormSerialReader()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try {
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
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error connecting to port, try reselecting the port in the drop down menu");
            }
            catch
            {
                Console.WriteLine("No clue what happened, not a System.IO.IOException");
            }


        }

        private void ListComPort_MouseClick(object sender, MouseEventArgs e)
        {
            ListComPort.Items.Clear();
            ListComPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void FormSerialReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort.Close();
        }

        private void ListComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Close();
                ButtonConnect.Text = "Connect";
                Console.WriteLine("Closed previous serial port");
                SerialPort.PortName = ListComPort.Text;
            }
            catch
            {
                Console.WriteLine("An error occurred while changing ports, please try again");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int firstByte = 0;
            //if (serialReadQueue.TryPeek(out firstByte))
            //{
            //    Console.WriteLine("Queue could not be read");
            //    return;
            //}
            //if(serialReadQueue.Count >= 4 && firstByte == 255)
            //{

            //}
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //References Sept 7, 2018 12PM Lecture.
            int newByte;

            while (SerialPort.BytesToRead != 0)
            {
                newByte = SerialPort.ReadByte();
                serialReadQueue.Enqueue(newByte);
            }
        }
    }
}
