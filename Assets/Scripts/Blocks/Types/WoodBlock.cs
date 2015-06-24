
public class WoodBlock : Block {

    private int touchnumber = 1;

    protected override void OnBallTouched()
    {
        touchnumber--;
        if (touchnumber == 0)
        {
            OnStriked(true);
        }
        else OnStriked(false);
    }
}
