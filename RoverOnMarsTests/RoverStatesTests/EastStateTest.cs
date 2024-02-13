using MarsRover.RoverState;
using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace MarsRoverCodingChallenge.Tests
{
    public class EastStateTest
    {
        private EastState _eastState;
        private Rover _rover;

        public EastStateTest()
        {
            _eastState = new EastState();
            _rover = new Rover(0, 0, _eastState);
        }

        [Fact]
        public void Move_ShouldIncreaseXCoordinate()
        {
            var initialX = _rover.X;
            _eastState.Move(_rover);
            Assert.Equal(initialX + 1, _rover.X);
        }

        [Fact]
        public void TurnLeft_ShouldChangeStateToNorthState()
        {
            _eastState.TurnLeft(_rover);
            Assert.IsType<NorthState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.North, _rover.CurrentState.FacingTo);
        }

        [Fact]
        public void TurnRight_ShouldChangeStateToSouthState()
        {
            _eastState.TurnRight(_rover);
            Assert.IsType<SouthState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.South, _rover.CurrentState.FacingTo);
        }
    }
}


