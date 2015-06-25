using UnityEngine;

namespace Assets.Scripts.Platforms
{
    public class PlatformController : MonoBehaviour
    {
        public Platform platform;
        private Vector2 pos;

        void Start ()
        {
            pos = platform.GetComponent<RectTransform>().anchoredPosition;
        }


        public void OnBallLost()
        {
           SetPlatformToInitialPosition();
        }

        public void OnWin()
        {
            SetPlatformToInitialPosition();
        }

        public void SetPlatformToInitialPosition()
        {
            platform.GetComponent<RectTransform>().anchoredPosition = pos;
        }
    }
}
