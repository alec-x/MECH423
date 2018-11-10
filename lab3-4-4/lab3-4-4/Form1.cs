using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
namespace lab3_4_4
{
    public partial class Form1 : Form
    {
        long timeCounter = 0; //use stopwatch?
        double currVelocity = 0;
        Int32 totalPos = 0;
        double pwmConverted;
        Stopwatch stopWatch;
        ConcurrentQueue<int> dataBuffer = new ConcurrentQueue<int>();
        List<int> averagePos = new List<int>(); //100 points long
        List<double> velocity = new List<double>(); //100 points long
        //ConcurrentQueue<int> encoderDown = new ConcurrentQueue<int>();
        public Form1()
        {
            InitializeComponent();
            speedChart.Series["encoderChangeInPosition"].Points.DataBindY(averagePos);
            speedChart.Series["motorSpeed"].Points.DataBindY(velocity);

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            toggleConnect();
            
        }

        private void comCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                toggleConnect();
            }
            
        }

        private void comCombo_MouseClick(object sender, MouseEventArgs e)
        {
            updatePortList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                toggleConnect();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            readSerialBuffer();
            stopWatch.Stop();
            timeCounter = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();
            stopWatch.Start();
            updateSpeed();
            speedChart.Series["encoderChangeInPosition"].Points.DataBindY(averagePos);
            speedChart.Series["motorSpeed"].Points.DataBindY(velocity);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            readSerial();
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            if (posModCheck.Checked)
            {
                try
                {
                    byte[] TxBytes = new byte[5];

                    byte dataByte1, dataByte2;

                    dataByte1 = Convert.ToByte(Convert.ToInt16(posModText.Text) >> 8);
                    dataByte2 = Convert.ToByte(Convert.ToInt16(posModText.Text) % 255);

                    TxBytes[0] = Convert.ToByte(255);
                    TxBytes[1] = dataByte1;
                    TxBytes[2] = dataByte2;
                    if (directionCheck.Checked)
                    {
                        TxBytes[3] = Convert.ToByte(0);
                    }
                    else
                    {
                        TxBytes[3] = Convert.ToByte(1);
                    }
                    if (dataByte1 == 255)
                    {
                        TxBytes[4] = Convert.ToByte(1);
                        TxBytes[1] = Convert.ToByte(254);
                    }
                    else if (dataByte2 == 255)
                    {
                        TxBytes[4] = Convert.ToByte(2);
                        TxBytes[2] = Convert.ToByte(254);
                    }
                    else if (dataByte1 == 255 && dataByte2 == 255)
                    {
                        TxBytes[4] = Convert.ToByte(3);
                        TxBytes[2] = Convert.ToByte(254);
                        TxBytes[1] = Convert.ToByte(254);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        serialPort.Write(TxBytes, i, 1);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Could not send bytes");
                    Console.WriteLine(exception.Message);
                }
            }
            else
            {
                if (pwmText.Text != "")
                {
                    sendBytes(Convert.ToDouble(pwmText.Text));
                }
            }

                
        }
    }

}
