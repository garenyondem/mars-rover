using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Rover
    {
        private readonly IPoisition _position;
        public IDirection Direction { get; private set; }
        public Rover(IPoisition position)
        {
            _position = position;
            Direction = new Direction(_position);
        }
        public void Move() => Direction.Move();
        public void TurnLeft() => Direction.TurnLeft();
        public void TurnRight() => Direction.TurnRight();
    }
}