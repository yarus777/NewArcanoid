using UnityEngine;
using Assets.Scripts;
using UnityEngine.UI;

public class VisualizeText : MonoBehaviour
{

    public Text LivesText;
    public Text ScoreText;
    private LivesHandler lvhandler;
    private ScoreHandler schandler;

    public void Init(LivesHandler handler, ScoreHandler handler1)
    {
        lvhandler = handler;
        schandler = handler1;
    }

	void Update () {

	    if (lvhandler != null)
	    {
	        LivesText.text = "Lives: " + lvhandler.lives.ToString();
	    }

        if (schandler != null)
        {
            ScoreText.text = "Score: " + schandler.score.ToString();
        }

	}
}
