using MarsRover.RoverState;
using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace MarsRoverCodingChallenge.Tests
{
    public class WestStateTest
    {
        private WestState _westState;
        private Rover _rover;

        public WestStateTest()
        {
            _westState = new WestState();
            _rover = new Rover(0, 0, _westState);
        }

        [Fact]
        public void Move_ShouldDecreaseXCoordinate()
        {
            var initialX = _rover.X;
            _westState.Move(_rover);
            Assert.Equal(initialX - 1, _rover.X);
        }

        [Fact]
        public void TurnLeft_ShouldChangeStateToSouthState()
        {
            _westState.TurnLeft(_rover);
            Assert.IsType<SouthState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.South, _rover.CurrentState.FacingTo);
        }

        [Fact]
        public void TurnRight_ShouldChangeStateToNorthState()
        {
            _westState.TurnRight(_rover);
            Assert.IsType<NorthState>(_rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.North, _rover.CurrentState.FacingTo);
        }
    }
}


