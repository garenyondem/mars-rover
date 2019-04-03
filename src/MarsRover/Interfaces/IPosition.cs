using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IPosition
    {
        Point Point { get; }
        void IncreaseX();
        void DecreaseX();
        void IncreaseY();
        void DecreaseY();
    }
}