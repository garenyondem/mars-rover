namespace MarsRover.Interfaces
{
    public interface IDirection
    {
        string Name { get; }
        void Move();
        void TurnLeft();
        void TurnRight();
    }
}