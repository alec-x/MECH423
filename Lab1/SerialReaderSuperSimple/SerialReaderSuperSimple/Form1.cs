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
        ConcurrentQueue<int> serialReadQueue = new ConcurrentQueue<int>();
        

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
                    Console.WriteLine(String.Format("Disconnected from serial port {0}", SerialPort.PortName));
                }
                else
                {
                    while(true)
                    {
                        SerialPort.Open();
                        
                        if(SerialPort.BytesToRead == 0)
                        {
                            System.Threading.Thread.Sleep(50);
                            SerialPort.Close();
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    ButtonConnect.Text = "Disconnect";
                    Console.WriteLine(String.Format("Connected to serial port {0}", SerialPort.PortName));
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error connecting to port, try reselecting the port in the drop down menu");
            }
            catch (Exception other)
            {
                Console.WriteLine(other);
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
            int xByte, yByte, zByte;
            while (firstByte != 255 && !serialReadQueue.IsEmpty)
            {
                serialReadQueue.TryDequeue(out firstByte);
            }
            while(serialReadQueue.Count >= 6 && firstByte == 255)
            {
                serialReadQueue.TryDequeue(out xByte);
                serialReadQueue.TryDequeue(out yByte);
                serialReadQueue.TryDequeue(out zByte);
                serialReadQueue.TryDequeue(out firstByte);
                TextX.Text = (xByte - 125).ToString(); //normalized data to disclude constant error?
                TextY.Text = (yByte - 124).ToString();
                TextZ.Text = (zByte - 154).ToString();
            }
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
