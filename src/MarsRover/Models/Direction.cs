using System;
using System.Linq;
using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Direction : IDirection
    {
        readonly IPoisition _position;
        static readonly string[] _cardinalDirections = { "North", "East", "South", "West" };
        public string Name { get; private set; } = _cardinalDirections.First(); // initial direction
        public Direction(IPoisition position)
        {
            _position = position;
        }
        public void Move()
        {
            if (string.Equals(Name, _cardinalDirections[0])) // Up
            {
                _position.IncreaseY();
            }
            else if (string.Equals(Name, _cardinalDirections[1])) // Right
            {
                _position.IncreaseX();
            }
            else if (string.Equals(Name, _cardinalDirections[2])) // Down
            {
                _position.DecreaseY();
            }
            else if (string.Equals(Name, _cardinalDirections[3])) // Left
            {
                _position.DecreaseX();
            }
        }
        public void TurnLeft()
        {
            if (string.Equals(Name, _cardinalDirections.First()))
            {
                Name = _cardinalDirections.Last();
            }
            else
            {
                var currentPosition = Array.IndexOf(_cardinalDirections, Name);
                var leftPosition = currentPosition - 1;
                Name = _cardinalDirections[leftPosition];
            }
        }
        public void TurnRight()
        {
            if (string.Equals(Name, _cardinalDirections.Last()))
            {
                Name = _cardinalDirections.First();
            }
            else
            {
                var currentPosition = Array.IndexOf(_cardinalDirections, Name);
                var rightPosition = currentPosition + 1;
                Name = _cardinalDirections[rightPosition];
            }
        }
    }
}