using MarsRover.RoverState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCodingChallenge.RoverState
{
    public class NorthState : IRoverState
    {
        public CardinalCompassPoint FacingTo
        {
            get
            {
                return CardinalCompassPoint.North;
            }
        }

        public void Move(Rover rover)
        {
            rover.Y++;
        }

        public void TurnLeft(Rover rover)
        {
            rover.CurrentState = new WestState();
        }

        public void TurnRight(Rover rover)
        {
            rover.CurrentState = new EastState();
        }
    }
}
