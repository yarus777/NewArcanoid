using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Debug = UnityEngine.Debug;

namespace Assets.Scripts
{
    public class ScoreHandler
    {
        public int score;

        public ScoreHandler(int score)
        {
            this.score = score;
        }

        public void OnBlockTouch()
        {
            score = score + 50;
        }
    }
}
