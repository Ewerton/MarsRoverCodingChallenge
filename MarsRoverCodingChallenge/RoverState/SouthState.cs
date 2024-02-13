using MarsRover.RoverState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCodingChallenge.RoverState
{
    public class SouthState : IRoverState
    {
        public CardinalCompassPoint FacingTo
        {
            get
            {
                return CardinalCompassPoint.South;
            }
        }

        public void Move(Rover rover)
        {
            rover.Y--;
        }

        public void TurnLeft(Rover rover)
        {
            rover.CurrentState = new EastState();
        }

        public void TurnRight(Rover rover)
        {
            rover.CurrentState = new WestState();
        }
    }
}
