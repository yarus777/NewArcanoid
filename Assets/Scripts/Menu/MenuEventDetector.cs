using UnityEngine;
using System.Collections;

public class MenuEventDetector : MonoBehaviour {

    public void onPlayButtonClick()
    {
       Application.LoadLevel("GameScene"); 
    }


}
