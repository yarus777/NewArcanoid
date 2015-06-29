using System;
using Assets.Scripts.Blocks;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour {
    public void Init(BlockInfo blockInfo)
    {
       GetComponent<RectTransform>().anchoredPosition = new Vector2(blockInfo.X, blockInfo.Y);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        OnBallTouched();
    }


    protected virtual void OnBallTouched()
    {
        OnStriked(true);
    }

    public delegate void OnstrickedDelegate(Block block, bool wasStriked);

    public event OnstrickedDelegate Striked;

    protected void OnStriked(bool wasStriked)
    {
        if (Striked != null)
        {
            Striked(this, wasStriked);
        }
    }

    private Image texture;
    protected void ChangeTexture(int num)
    {
        //Debug.Log(num);
        String path = "";
        switch (num)
        {
            case 1:
                path = "Blocks/Textures/Wood";
                break;
            case 2:
                path = "Blocks/Textures/Stone";
                break;
            case 3:
                path = "Blocks/Textures/Metal";
                break;
        }
        //Debug.Log(path);
        texture = GetComponent<Image>();
        texture.sprite = Resources.Load<Sprite>(path);
    }
}
