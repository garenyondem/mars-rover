using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IDirection
    {
        string Name { get; }
        Point Move();
        void TurnLeft();
        void TurnRight();
    }
}