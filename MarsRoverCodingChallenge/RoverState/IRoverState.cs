using MarsRover.RoverState;

namespace MarsRoverCodingChallenge.RoverState
{
    public interface IRoverState
    {
        void Move(Rover rover);
        void TurnLeft(Rover rover);
        void TurnRight(Rover rover);
        CardinalCompassPoint FacingTo { get; }
    }
}
