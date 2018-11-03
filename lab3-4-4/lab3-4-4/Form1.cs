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
        Stopwatch stopWatch;
        ConcurrentQueue<int> dataBuffer = new ConcurrentQueue<int>();
        List<int> averagePos = new List<int>(); //150 points long

        
        //ConcurrentQueue<int> encoderDown = new ConcurrentQueue<int>();
        public Form1()
        {
            InitializeComponent();
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
            stopWatch.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            readSerial();
        }
    }
}
