using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IPoisition
    {
        Point Point { get; }
        void IncreaseX();
        void DecreaseX();
        void IncreaseY();
        void DecreaseY();
    }
}