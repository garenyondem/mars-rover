
public class Position : IPoisition
{
    public int x { get; private set; } = 0;
    public int y { get; private set; } = 0;
    readonly Grid _grid;
    public Position(Grid grid)
    {
        _grid = grid;
    }
    public void IncreaseX()
    {
        if (x < _grid.width)
        {
            x++;
        }
    }
    public void DecreaseX()
    {
        if (x > 0)
        {
            x--;
        }
    }
    public void IncreaseY()
    {
        if (y < _grid.height)
        {
            y++;
        }
    }
    public void DecreaseY()
    {
        if (y > 0)
        {
            y--;
        }
    }
}