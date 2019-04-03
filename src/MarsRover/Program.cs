using System;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(10, 5);
            IPoisition initialPosition = new Position(grid);
            var myRover = new Rover(initialPosition);
            myRover.TurnRight();
            myRover.Move();
            myRover.Move();
            myRover.Move();
            myRover.Move();
            myRover.TurnLeft();
            myRover.Move();

            Console.WriteLine($"{myRover.Point.x} {myRover.Point.y} {myRover.Direction.Name}");

            // TODO: Prep parser for external commands
        }
    }
}