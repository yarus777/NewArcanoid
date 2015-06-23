using UnityEngine;

namespace Assets.Scripts.Platforms
{
    public class PlatformController : MonoBehaviour
    {

        private Vector2 pos;

        void Start ()
        {
            pos = GetComponent<RectTransform>().anchoredPosition;
        }


        public void OnBallLost()
        {
            GetComponent<RectTransform>().anchoredPosition = pos;
        }
    }
}
