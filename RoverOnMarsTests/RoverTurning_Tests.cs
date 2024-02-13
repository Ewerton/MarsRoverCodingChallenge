using MarsRover.RoverState;
using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace RoverOnMarsTests
{
    public class RoverTurning_Tests
    {
        private Rover _rover;
        private IRoverState _initialState;

        [Fact]
        public void TurnLeft_ShouldChangeState()
        {
            // Arrange
            _initialState = new NorthState();
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.TurnLeft();

            // Assert
            Assert.Equal(CardinalCompassPoint.West, _rover.CurrentState.FacingTo);
        }

        [Fact]
        public void TurnRight_ShouldChangeState()
        {
            // Arrange
            _initialState = new NorthState(); 
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.TurnRight();

            // Assert
            Assert.Equal(CardinalCompassPoint.East, _rover.CurrentState.FacingTo);
        }

        [Fact]
        public void Turn360_ShouldChangeState()
        {
            // Arrange
            _initialState = new NorthState();
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.TurnLeft();

            // Assert
            Assert.Equal(CardinalCompassPoint.West, _rover.CurrentState.FacingTo);

            // Act
            _rover.TurnLeft();

            // Assert
            Assert.Equal(CardinalCompassPoint.South, _rover.CurrentState.FacingTo);

            // Act
            _rover.TurnLeft();

            // Assert
            Assert.Equal(CardinalCompassPoint.East, _rover.CurrentState.FacingTo);

            // Act
            _rover.TurnLeft();

            // Assert
            Assert.Equal(CardinalCompassPoint.North, _rover.CurrentState.FacingTo);
        }
    }

}