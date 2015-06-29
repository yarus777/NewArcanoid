using Assets.Scripts.Balls;
using Assets.Scripts.Platforms;
using UnityEngine;

namespace Assets.Scripts
{
    public class EventDetector : MonoBehaviour
    {

        public Ball ball;
        public Platform platform;
        private Camera camera;
        private float yballpos;

        void Start () 
        {
            camera = Camera.main;
            yballpos = ball.transform.position.y;
        }

        public void OnscreenClick()
        {
            ball.SendBall();
        }

        private float prevpos;
        private bool isPressed = false;

        public void FixedUpdate()
        {
            if (!isPressed)
            {
                return;
            }
            Vector2 pos = camera.ScreenToWorldPoint(Input.mousePosition);
            platform.rigidbody2D.velocity = new Vector2((pos.x - prevpos) / Time.fixedDeltaTime, 0);
            if (!ball.IsRunning)
            ball.transform.position = new Vector2(platform.transform.position.x, yballpos);
            prevpos = pos.x;
            
        }

        public void OnFingerUp()
        {
            platform.rigidbody2D.velocity = Vector2.zero;
            isPressed = false;
        }

        public void OnFingerDown()
        {
            Vector2 clickPosition = camera.ScreenToWorldPoint(Input.mousePosition);
            prevpos = clickPosition.x;
            isPressed = true;
            //ball.SendBall();
        }
    }
}
