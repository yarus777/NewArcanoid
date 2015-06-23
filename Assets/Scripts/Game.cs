using Assets.Scripts.Balls;
using Assets.Scripts.Platforms;
using UnityEngine;

namespace Assets.Scripts
{
    public class Game : MonoBehaviour
    {

        public BallController ballcontroller;
        public PlatformController platformcontroller;
        private LivesHandler liveshandler;
        public VisualizeText visulizetext;

        void Start ()
        {

            ballcontroller.ball.Lost += OnBallLost;
            liveshandler = new LivesHandler(3);
            visulizetext.Init(liveshandler);

        }

        private void OnBallLost(Ball ball)
        {
            ballcontroller.OnBallLost();
            platformcontroller.OnBallLost();
            liveshandler.OnBallLost();
        }
	
    }
}
