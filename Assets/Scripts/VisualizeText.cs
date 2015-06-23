using UnityEngine;
using Assets.Scripts;
using UnityEngine.UI;

public class VisualizeText : MonoBehaviour
{

    public Text LivesText;
    private LivesHandler lvhandler;

    public void Init(LivesHandler handler)
    {
        lvhandler = handler;
    }

	void Update () {

	    if (lvhandler != null)
	    {
	        LivesText.text = "Lives: " + lvhandler.lives.ToString();
	    }
	}
}
