namespace MarsRover.Models
{
    public class Grid
    {
        public int width { get; private set; }
        public int height { get; private set; }
        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}