using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class WhackAMoleGame
    {
        private int score;
        private int round;
        private int time;
        private int gameState;
        private System.Windows.Forms.PictureBox up, down, left, right, centre;
        private System.Windows.Forms.ListBox dialogue;

        public WhackAMoleGame(System.Windows.Forms.PictureBox upPicture,
                              System.Windows.Forms.PictureBox downPicture,
                              System.Windows.Forms.PictureBox leftPicture,
                              System.Windows.Forms.PictureBox rightPicture,
                              System.Windows.Forms.PictureBox centrePicture,
                              System.Windows.Forms.ListBox dialogueBox)
        {
            score = 0;
            round = 0;
            time = 0;
            gameState = 0;
            up = upPicture;
            down = downPicture;
            left = leftPicture;
            right = rightPicture;
            centre = centrePicture;
            dialogue = dialogueBox;
        }

        public void RandomMole()
        {

        }

    }
}
