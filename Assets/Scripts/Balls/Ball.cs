
using UnityEngine;

namespace Assets.Scripts.Balls
{
    public class Ball : MonoBehaviour
    {

        public bool IsRunning = false;
        private Vector2 ballInitialForce;
        private float initialSpeed = 400;
        public Canvas canvas;

        void Start () {
            ballInitialForce = new Vector2(1f, 1f);
            initialSpeed *= canvas.scaleFactor;
        }

        public void SendBall()
        {
            if (!IsRunning)
            {
                //rigidbody2D.AddForce(ballInitialForce);
                rigidbody2D.velocity = Vector2.up * initialSpeed;              
                IsRunning = true;
            }
            
        }

        public void StopBall()
        {
            IsRunning = false;
        }

        public float GetBallSpeed(float platformSpeed)
        {
            if (platformSpeed == 0)
                return 1;
            return Mathf.Abs(platformSpeed)/initialSpeed;
        }

        float hitPoint(Vector2 ballPos, Vector2 platformPos, float platformWidth )
        {
            return (ballPos.x - platformPos.x)/platformWidth;
        }
        public void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.name == "Platform" && IsRunning)
            {
                float x = hitPoint(transform.position, col.transform.position, col.collider.bounds.size.x);
                Vector2 dir = new Vector2(x,1).normalized;              
                rigidbody2D.velocity = dir * initialSpeed * GetBallSpeed(col.rigidbody.velocity.x);
            }
        }

        public delegate void BallLostDelegate(Ball ball);

        public event BallLostDelegate Lost;

        private void OnBallLost()
        {
            if (Lost != null)
            {
                Lost(this);
               
            }
        }

        void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.name == "BottomBorder")
            {
                OnBallLost();
            }
        }

    }
}
