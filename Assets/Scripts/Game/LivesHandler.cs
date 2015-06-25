

using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Assets.Scripts
{
    public class LivesHandler
    {
        public int lives;

        public void OnBallLost()
        {   if (lives>0)
            lives--;
            if (lives == 0)
            {
                Debug.Log("You lost!");
            }
        }

        public LivesHandler(int lives)
        {
            this.lives = lives;
        }
    }
}
