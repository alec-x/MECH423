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
        private int difficulty;
        private int time;
        private int totalTime;
        private int gamestate;
        private int currMole;
        private Random rand = new Random();
        private List<System.Windows.Forms.PictureBox> listMoles;
        IDictionary<int, string> moleDict = new Dictionary<int, string>()
        {
            { 0, " +Z" },
            { 1, " -Z" },
            { 2, " -Y" },
            { 3, " +Y" },
            { 4, " +X" },
        };


        public WhackAMoleGame(ref List<System.Windows.Forms.PictureBox> x)
        {
            score = 0;
            difficulty = 1;
            time = 0;
            totalTime = 0;
            gamestate = 0;
            currMole = 0;
            listMoles = x;
        }

        public void GameStart(int difficultyLevel)
        {
            gamestate = 1;
            difficulty = difficultyLevel;
            totalTime = 60000;
            score = 0;
        }

        public int GetState()
        {
            return gamestate;
        }

        public void GameLoop(string direction)
        {
            if(totalTime <= 0)
            {
                GameStop();
            }
            if(time <= 0)
            {
                time = 2400/difficulty;
                
                foreach(System.Windows.Forms.PictureBox moleBox in listMoles)
                {
                    moleBox.Image = null;
                }

                currMole = rand.Next(0, 5);
                listMoles[currMole].Image = Lab1.Properties.Resources.mole;
                
            }
            else
            {
                time -= 50;
                string lookup;


                if (moleDict.TryGetValue(currMole, out lookup) && direction.Contains(lookup))
                {
                    score += 100 * difficulty;
                    listMoles[currMole].Image = null;
                }
            }
            totalTime -= 50;
        }

        public void GameStop()
        {
            difficulty = 1;
            time = 0;
            totalTime = 0;
            currMole = 0;
            gamestate = 0;
        }

        public int GetTime()
        {
            return totalTime;
        }
        public int GetScore()
        {
            return score;
        }

    }
}
