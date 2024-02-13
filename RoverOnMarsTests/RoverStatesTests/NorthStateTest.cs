using MarsRover.RoverState;
using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace RoverOnMarsTests.RoverStatesTests
{
    public class NorthStateTest
    {
        private NorthState _northState;
        private Rover _rover;

        public NorthStateTest()
        {
            _northState = new NorthState();
            _rover = new Rover(0, 0, _northState);
        }

        [Fact]
        public void Move_ShouldIncreaseYCoordinate()
        {
            var initialY = _rover.Y;
            _northState.Move(_rover);
            Assert.Equal(initialY + 1, _rover.Y);
        }

        [Fact]
        public void TurnLeft_ShouldChangeStateToWestState()
        {
            _northState.TurnLeft(_rover);
            Assert.IsType<WestState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.West, _rover.CurrentState.FacingTo);
        }

        [Fact]
        public void TurnRight_ShouldChangeStateToEastState()
        {
            _northState.TurnRight(_rover);
            Assert.IsType<EastState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.East, _rover.CurrentState.FacingTo);
        }
    }
}


