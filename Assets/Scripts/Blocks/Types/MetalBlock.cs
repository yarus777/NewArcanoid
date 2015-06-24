

public class MetalBlock : Block
{

    private int touchnumber = 3;

    protected override void OnBallTouched()
    {
        touchnumber--;
        ChangeTexture(touchnumber);
        if (touchnumber == 0)
        {
            OnStriked(true);
        }
        else OnStriked(false);
    }
}
