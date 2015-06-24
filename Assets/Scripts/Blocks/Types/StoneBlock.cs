

public class StoneBlock : Block {

    private int touchnumber = 2;

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
