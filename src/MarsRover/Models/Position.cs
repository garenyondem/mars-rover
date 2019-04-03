using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Position : IPosition
    {
        public Point Point { get; private set; } = new Point();
        readonly Grid _grid;
        public Position(Grid grid)
        {
            _grid = grid;
        }
        public void IncreaseX()
        {
            if (Point.x < _grid.width)
            {
                Point.x++;
            }
        }
        public void DecreaseX()
        {
            if (Point.x > 0)
            {
                Point.x--;
            }
        }
        public void IncreaseY()
        {
            if (Point.y < _grid.height)
            {
                Point.y++;
            }
        }
        public void DecreaseY()
        {
            if (Point.y > 0)
            {
                Point.y--;
            }
        }
    }
}