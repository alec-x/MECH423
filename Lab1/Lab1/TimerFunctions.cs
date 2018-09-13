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
        private void updateChart()
        {
            ChartAcceleration.Series["SeriesX"].Points.Clear();
            foreach (int point in xAvgList)
            {

                ChartAcceleration.Series["SeriesX"].Points.AddY((double)point);
            }

            ChartAcceleration.Series["SeriesY"].Points.Clear();
            foreach (int point in yAvgList)
            {

                ChartAcceleration.Series["SeriesY"].Points.AddY((double)point);
            }

            ChartAcceleration.Series["SeriesZ"].Points.Clear();
            foreach (int point in zAvgList)
            {

                ChartAcceleration.Series["SeriesZ"].Points.AddY((double)point);
            }
        }

        private void readBuffer()
        {
            int firstByte = 0;
            int xByte, yByte, zByte;

            while (firstByte != 255 && !serialReadQueue.IsEmpty)
            {
                serialReadQueue.TryDequeue(out firstByte);
            }

            if (serialReadQueue.Count >= 4 && firstByte == 255)
            {
                serialReadQueue.TryDequeue(out xByte);
                serialReadQueue.TryDequeue(out yByte);
                serialReadQueue.TryDequeue(out zByte);
                serialReadQueue.TryDequeue(out firstByte);
                xByte -= 124;
                yByte -= 124;
                zByte -= 154;
                while (xAvgList.Count >= 100) { xAvgList.RemoveAt(0); }
                while (yAvgList.Count >= 100) { yAvgList.RemoveAt(0); }
                while (zAvgList.Count >= 100) { zAvgList.RemoveAt(0); }
                xAvgList.Add(xByte);
                yAvgList.Add(yByte);
                zAvgList.Add(zByte);

                TextAvgAccelX.Text = xAvgList.Average().ToString();
                TextAvgAccelY.Text = yAvgList.Average().ToString();
                TextAvgAccelZ.Text = zAvgList.Average().ToString();

                TextAccelX.Text = (xByte).ToString(); //normalized data to disclude constant error?
                TextAccelY.Text = (yByte).ToString();
                TextAccelZ.Text = (zByte).ToString();
            }
        }
        private string GetOrientation()
        {
            int diff = 2000; //as long as bigger than 255 * 2 * 3 should be ok 2 for +/- 3 for x y z
            int currDiff;
            string orientation = "UNDETECTED";
            if (xAvgList.Any())
            {
                foreach (KeyValuePair<string, List<int>> entry in orientationList)
                {
                    currDiff = Math.Abs(entry.Value[0] - xAvgList.Last()) +
                               Math.Abs(entry.Value[1] - yAvgList.Last()) +
                               Math.Abs(entry.Value[2] - zAvgList.Last());
                    if (currDiff < diff)
                    {
                        diff = currDiff;
                        orientation = entry.Key;
                    }
                }
            }


            return orientation;
        }

        private void updateBufferBar()
        {
            if (SerialPort.IsOpen)
            {
                ProgressBarBuffer.Value = SerialPort.BytesToRead;
                TextProgressBar.Text = SerialPort.BytesToRead.ToString() +
                                       "/" + SerialPort.ReadBufferSize;
            }
        }


    }
}
