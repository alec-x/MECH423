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

namespace Lab1
{
    public partial class MainForm : Form
    {
        ConcurrentQueue<int> serialReadQueue = new ConcurrentQueue<int>();
        List<int> xAvgList = new List<int>();
        List<int> yAvgList = new List<int>();
        List<int> zAvgList = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            int firstByte = 0;
            int xByte, yByte, zByte;
            while (firstByte != 255 && !serialReadQueue.IsEmpty)
            {
                serialReadQueue.TryDequeue(out firstByte);
            }
            while (serialReadQueue.Count >= 4 && firstByte == 255)
            {
                serialReadQueue.TryDequeue(out xByte);
                serialReadQueue.TryDequeue(out yByte);
                serialReadQueue.TryDequeue(out zByte);
                serialReadQueue.TryDequeue(out firstByte);

                while (xAvgList.Count >= 100) { xAvgList.RemoveAt(0); }
                while (yAvgList.Count >= 100) { yAvgList.RemoveAt(0); }
                while (zAvgList.Count >= 100) { zAvgList.RemoveAt(0); }
                xAvgList.Add(xByte - 125);
                yAvgList.Add(yByte - 124);
                zAvgList.Add(zByte - 154);

                TextAvgAccelX.Text = xAvgList.Average().ToString();
                TextAvgAccelY.Text = yAvgList.Average().ToString();
                TextAvgAccelZ.Text = zAvgList.Average().ToString();

                TextAccelX.Text = (xByte - 125).ToString(); //normalized data to disclude constant error?
                TextAccelY.Text = (yByte - 124).ToString();
                TextAccelZ.Text = (zByte - 154).ToString();

                ChartAcceleration.DataBind();
            }
            if (SerialPort.IsOpen)
            {
                ProgressBarBuffer.Value = SerialPort.BytesToRead;
                TextProgressBar.Text = SerialPort.BytesToRead.ToString() + 
                                       "/" + SerialPort.ReadBufferSize;
            }
            
        }

        private void ComboPortList_MouseClick(object sender, MouseEventArgs e)
        {
            ComboPortList.Items.Clear();
            ComboPortList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort.Close();
        }

        private void ComboPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Close();
                ButtonConnect.Text = "Connect";
                Console.WriteLine("Closed previous serial port");
                SerialPort.PortName = ComboPortList.Text;
            }
            catch
            {
                Console.WriteLine("An error occurred while changing ports, please try again");
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

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort.IsOpen)
                {
                    SerialPort.Close();
                    ButtonConnect.Text = "Connect";
                    Console.WriteLine(String.Format("Disconnected from serial port {0}", SerialPort.PortName));
                }
                else
                {
                    SerialPort.Open();
                    ButtonConnect.Text = "Disconnect";
                    Console.WriteLine(String.Format("Connected to serial port {0}", SerialPort.PortName));
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChartAcceleration.DataSource = xAvgList;

        }
    }
}
