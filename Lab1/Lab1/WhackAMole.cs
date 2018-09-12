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
        private int gamestate;
        private bool up, down, left, right, centre;

        public WhackAMoleGame()
        {
            score = 0;
            round = 0;
            time = 0;
            gamestate = 0;
            up = down = left = right = centre = false;
        }

        public void GameStart()
        {
            gamestate = 1;
        }

        public void PlayRound()
        {

        }

        public void GameStop()
        {
            score = 0;
            round = 0;
            time = 0;
            up = down = left = right = centre = false;
            gamestate = 0;
        }

        public int GetScore()
        {
            return score;
        }

    }
}
