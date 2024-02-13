using MarsRover.RoverState;
using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace MarsRoverCodingChallenge.Tests
{
    public class SouthStateTest
    {
        private SouthState _southState;
        private Rover _rover;

        public SouthStateTest()
        {
            _southState = new SouthState();
            _rover = new Rover(0, 0, _southState);
        }

        [Fact]
        public void Move_ShouldDecreaseYCoordinate()
        {
            var initialY = _rover.Y;
            _southState.Move(_rover);
            Assert.Equal(initialY - 1, _rover.Y);
        }

        [Fact]
        public void TurnLeft_ShouldChangeStateToEastState()
        {
            _southState.TurnLeft(_rover);
            Assert.IsType<EastState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.East, _rover.CurrentState.FacingTo);
        }

        [Fact]
        public void TurnRight_ShouldChangeStateToWestState()
        {
            _southState.TurnRight(_rover);
            Assert.IsType<WestState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.West, _rover.CurrentState.FacingTo);
        }
    }
}


