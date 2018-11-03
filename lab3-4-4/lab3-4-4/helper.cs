using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4_4
{
    public partial class Form1 : Form
    {
        private void updatePortList()
        {
            comCombo.Items.Clear();
            comCombo.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void changePort()
        {
            try
            {
                serialPort.Close();
                connectButton.Text = "Connect";
                Console.WriteLine("Closed previous serial port");
                serialPort.PortName = comCombo.Text;
            }
            catch
            {
                Console.WriteLine("An error occurred while changing ports, please try again");
            }
        }

        private void toggleConnect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    connectButton.Text = "Connect";
                    Console.WriteLine(String.Format("Disconnected from serial port {0}", serialPort.PortName));
                }
                else
                {
                    setPort();
                    serialPort.Open();
                    connectButton.Text = "Disconnect";
                    Console.WriteLine(String.Format("Connected to serial port {0}", serialPort.PortName));
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error connecting to port, try reselecting the port in the drop down menu");
            }

        }

        private void setPort()
        {
            try
            {
                serialPort.BaudRate = Convert.ToInt32(baudRateText.Text);
                serialPort.PortName = comCombo.SelectedItem.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not set serial Port parameters");
                Console.WriteLine(exception.Message);
            }
        }

        private void readSerial()
        {
            int newByte;

            while (serialPort.BytesToRead != 0)
            {
                newByte = serialPort.ReadByte();
                dataBuffer.Enqueue(newByte);
            }
        }
        private void readSerialBuffer()
        {
            int firstByte = 0;
            int encoderUp, encoderDown;
            int up1, up0, down1, down0, escape;
            while (firstByte != 255 && !dataBuffer.IsEmpty)
            {
                dataBuffer.TryDequeue(out firstByte);
            }
            while (dataBuffer.Count >= 4 && firstByte == 255)
            {
                dataBuffer.TryDequeue(out up1);
                dataBuffer.TryDequeue(out up0);
                dataBuffer.TryDequeue(out down1);
                dataBuffer.TryDequeue(out down0);
                dataBuffer.TryDequeue(out escape);
                if ((escape & 1) == 1)
                {
                    up1 = 255;
                }
                if ((escape & 2) == 2)
                {
                    up0 = 255;
                }
                if ((escape & 4) == 4)
                {
                    down1 = 255;
                }
                if ((escape & 8) == 8)
                {
                    down0 = 255;
                }
                encoderUp = (up1 << 8) + up0;
                encoderDown = (down1 << 8) + down0;
                while (averagePos.Count >= 150)
                {
                    averagePos.RemoveAt(0);
                }
                averagePos.Add(encoderUp - encoderDown);
                chart1.Series[0].Points.DataBindY(averagePos);
            }
        }
        private void updateSpeed()
        {
            // 1000 for ms to s, 1440 for window count to rotation
            speedText.Text = (1000*(double)averagePos.Sum()/timeCounter / 1440).ToString();
        }
    }
}
