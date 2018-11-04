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
            speedChart.Series["encoderPosition"].Points.DataBindY(averagePos);
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
            speedChart.Series["encoderPosition"].Points.DataBindY(averagePos);
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
            if (pwmText.Text != "")
            {
                sendBytes(Convert.ToDouble(pwmText.Text));
            }
                
        }

        private void positionModCheck_CheckedChanged(object sender, EventArgs e)
        {
            speedModCheck.Checked = false;
        }

        private void speedModCheck_CheckedChanged(object sender, EventArgs e)
        {
            positionModCheck.Checked = false;
        }

        private void feedbackTimer_Tick(object sender, EventArgs e)
        {
            if (speedModCheck.Checked)
            {
                modulateSpeed();
            }
        }
    }

}
