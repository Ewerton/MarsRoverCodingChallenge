using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace RoverOnMarsTests
{
    public class RoverMooving_Tests
    {
        private Rover _rover;
        private IRoverState _initialState;

        [Fact]
        public void MoveNorth_ShouldChangePosition()
        {
            // Arrange
            _initialState = new NorthState();
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.Move();

            // Assert
            Assert.Equal(0, _rover.X);
            Assert.Equal(1, _rover.Y);
        }

        [Fact]
        public void MoveEast_ShouldChangePosition()
        {
            // Arrange
            _initialState = new EastState();
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.Move();

            // Assert
            Assert.Equal(1, _rover.X);
            Assert.Equal(0, _rover.Y);
        }

        [Fact]
        public void MoveSouth_ShouldChangePosition()
        {
            // Arrange
            _initialState = new SouthState();
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.Move();

            // Assert
            Assert.Equal(0, _rover.X);
            Assert.Equal(-1, _rover.Y);
        }

        [Fact]
        public void MoveWest_ShouldChangePosition()
        {
            // Arrange
            _initialState = new WestState();
            _rover = new Rover(0, 0, _initialState);

            // Act
            _rover.Move();

            // Assert
            Assert.Equal(-1, _rover.X);
            Assert.Equal(0, _rover.Y);
        }


    }

}