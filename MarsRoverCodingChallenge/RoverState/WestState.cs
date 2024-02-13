using MarsRover.RoverState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCodingChallenge.RoverState
{
    public class WestState : IRoverState
    {
        public CardinalCompassPoint FacingTo
        {
            get
            {
                return CardinalCompassPoint.West;
            }
        }

        public void Move(Rover rover)
        {
            rover.X--;
        }

        public void TurnLeft(Rover rover)
        {
            rover.CurrentState = new SouthState();
        }

        public void TurnRight(Rover rover)
        {
            rover.CurrentState = new NorthState();
        }
    }
}
