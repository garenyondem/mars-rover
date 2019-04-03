using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Rover
    {
        public Point Point { get; private set; }

        public IDirection Direction { get; private set; }
        public Rover(IPoisition position)
        {
            Direction = new Direction(position);
        }
        public void Move()
        {
            Point = Direction.Move();
        }
        public void TurnLeft() => Direction.TurnLeft();
        public void TurnRight() => Direction.TurnRight();
    }
}