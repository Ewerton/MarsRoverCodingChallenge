using MarsRover.RoverState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCodingChallenge.RoverState
{
    public class EastState : IRoverState
    {
        public CardinalCompassPoint FacingTo
        {
            get
            {
                return CardinalCompassPoint.East;
            }
        }

        public void Move(Rover rover)
        {
            rover.X++;
        }

        public void TurnLeft(Rover rover)
        {
            rover.CurrentState = new NorthState();
        }

        public void TurnRight(Rover rover)
        {
            rover.CurrentState = new SouthState();
        }
    }
}
