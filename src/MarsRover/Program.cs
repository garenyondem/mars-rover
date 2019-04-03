using System;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace mars_rover
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(10, 5);
            IPoisition initialPosition = new Position(grid);
            var myRover = new Rover(initialPosition);
            myRover.TurnLeft();
            myRover.TurnLeft();
            myRover.Move();
            myRover.TurnRight();
            Console.WriteLine(myRover.Direction.Name);

            // TODO: Get current position info from Rover
            // TODO: Prep parser for external commands
        }
    }
}