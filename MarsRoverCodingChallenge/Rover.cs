using MarsRover;
using MarsRoverCodingChallenge.RoverState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCodingChallenge
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }

        public IRoverState CurrentState { get; internal set; }

        public Rover(int x, int y, IRoverState initialState)
        {
            X = x;
            Y = y;
            CurrentState = initialState;
        }

        public void Move()
        {
            CurrentState.Move(this);
        }

        public void TurnLeft()
        {
            CurrentState.TurnLeft(this);
        }

        public void TurnRight()
        {
            CurrentState.TurnRight(this);
        }

        public override string ToString()
        {
            return $"Current position X:{X} Y:{Y}. Facing to {CurrentState.FacingTo.GetDisplayName()}";
        }
    }

}
