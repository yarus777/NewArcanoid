

namespace Assets.Scripts
{
    public class LivesHandler
    {
        public int lives;

        public void OnBallLost()
        {   if (lives>0)
            lives--;
        }

        public LivesHandler(int lives)
        {
            this.lives = lives;
        }
    }
}
