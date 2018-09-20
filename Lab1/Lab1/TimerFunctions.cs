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
                while (xAvgList.Count >= 125) { xAvgList.RemoveAt(0); }
                while (yAvgList.Count >= 125) { yAvgList.RemoveAt(0); }
                while (zAvgList.Count >= 125) { zAvgList.RemoveAt(0); }
                xAvgList.Add(xByte);
                yAvgList.Add(yByte);
                zAvgList.Add(zByte);

                TextAvgAccelX.Text = xAvgList.Max().ToString();
                TextAvgAccelY.Text = yAvgList.Max().ToString();
                TextAvgAccelZ.Text = zAvgList.Max().ToString();

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
            if (xAvgList.Any() && SerialPort.IsOpen)
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
            else
            {
                orientation = "UNDETECTED";
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

        private void resetMoves()
        {
            moveTimer = 0;
            comboList = "";
            moveTrigger = false;
            PictureBoxX.BackColor = System.Drawing.Color.Transparent;
            PictureBoxY.BackColor = System.Drawing.Color.Transparent;
            PictureBoxZ.BackColor = System.Drawing.Color.Transparent;
        }

        private void recognizeMoves()
        {
            if (moveList.ContainsKey(comboList) && moveList.TryGetValue(comboList, out currentMove))
            {
                TextMovePerformed.Text = currentMove;
                moveDisplay = 1000;
                resetMoves();
            }
        }

        private string recognizeCurrentDirection()
        {
            string currentDirection = "";
            int currentDirectionThreshold = 0;
            int baseMoveThreshold = 30;
            moveSum[" +X"] = xAvgList[124];
            moveSum[" -X"] = xAvgList[124]; //Skip(97).Where(x => x < 0).Sum();
            moveSum[" +Y"] = yAvgList[124];  //Skip(97).Where(y => y > 0).Sum();
            moveSum[" -Y"] = yAvgList[124];  //Skip(97).Where(y => y < 0).Sum();
            moveSum[" +Z"] = zAvgList[124];  //Skip(97).Where(z => z > 0).Sum();
            moveSum[" -Z"] = zAvgList[124];  //Skip(97).Where(z => z < 0).Sum();
            foreach (KeyValuePair<string, int> sum in moveSum)
            {
                if (Math.Abs(sum.Value) > baseMoveThreshold && Math.Abs(sum.Value) > currentDirectionThreshold)
                {
                    moveTrigger = true;
                    currentDirectionThreshold = sum.Value;
                    currentDirection = sum.Key;
                }
            }

            switch (currentDirection)
            {
                case " +X":
                    PictureBoxX.BackColor = System.Drawing.Color.Green;
                    break;
                case " -X":
                    PictureBoxX.BackColor = System.Drawing.Color.Red;
                    break;
                case " +Y":
                    PictureBoxY.BackColor = System.Drawing.Color.Green;
                    break;
                case " -Y":
                    PictureBoxY.BackColor = System.Drawing.Color.Red;
                    break;
                case " +Z":
                    PictureBoxZ.BackColor = System.Drawing.Color.Green;
                    break;
                case " -Z":
                    PictureBoxZ.BackColor = System.Drawing.Color.Red;
                    break;
            }

// make switch cases for this shit
            return currentDirection;

        }

        private void avg50Accel()
        {
            double total = 0;
            int xSquare, ySquare, zSquare;
            for(int i = 75; i < 124; i++)
            {
                xSquare = (xAvgList[i] + 124) * (xAvgList[i] + 124);
                ySquare = (yAvgList[i] + 124) * (yAvgList[i] + 124);
                zSquare = (zAvgList[i] + 154) * (zAvgList[i] + 154);
                total +=  Math.Sqrt(xSquare + ySquare + zSquare);
            }
            total = total / 9.8 / 50;
            TextAvg50.Text = total.ToString();
        }

    }
}
