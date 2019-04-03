namespace MarsRover.Interfaces
{
    public interface IPoisition
    {
        int x { get; }
        int y { get; }
        void IncreaseX();
        void DecreaseX();
        void IncreaseY();
        void DecreaseY();
    }
}