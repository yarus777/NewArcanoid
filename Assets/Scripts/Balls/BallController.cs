using UnityEngine;

namespace Assets.Scripts.Balls
{
    public class BallController : MonoBehaviour
    {

        public Ball ball;
        private Vector2 pos;

        void Start ()
        {
            pos = ball.GetComponent<RectTransform>().anchoredPosition;

        }

        public void OnBallLost()
        {
            SetBallToInitialPosition();
            ball.StopBall();
        }

        public void OnWin()
        {
            ball.rigidbody2D.velocity = Vector2.zero;
            ball.GetComponent<RectTransform>().anchoredPosition = pos;
            ball.StopBall();
        }

        public void SetBallToInitialPosition()
        {
            ball.rigidbody2D.velocity = Vector2.zero;
            ball.GetComponent<RectTransform>().anchoredPosition = pos;
        }
    }
}
