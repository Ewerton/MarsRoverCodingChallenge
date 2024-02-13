using MarsRover.RoverState;
using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

namespace RoverOnMarsTests
{
    public class RoverInitialization_Tests
    {
        [Fact]
        public void Rover_InitializationToNorthIsCorrect()
        {
            // Arrange 
            var state = new NorthState();
            var rover = new Rover(0, 0, state);

            //Act

            // Assert
            Assert.NotNull(rover);
            Assert.NotNull(state);
            Assert.Equal(0, rover.X);
            Assert.Equal(0, rover.Y);
            Assert.Equal(state, rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.North, rover.CurrentState.FacingTo);
        }

        [Fact]
        public void Rover_InitializationToEastIsCorrect()
        {
            // Arrange
            var state = new EastState();
            var rover = new Rover(0, 0, state);

            //Assert
            Assert.NotNull(rover);
            Assert.NotNull(state);
            Assert.Equal(0, rover.X);
            Assert.Equal(0, rover.Y);
            Assert.Equal(state, rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.East, rover.CurrentState.FacingTo);
        }

        [Fact]
        public void Rover_InitializationToSouthIsCorrect()
        {
            // Arrange
            var state = new SouthState();
            var rover = new Rover(0, 0, state);

            //Assert
            Assert.NotNull(rover);
            Assert.NotNull(state);
            Assert.Equal(0, rover.X);
            Assert.Equal(0, rover.Y);
            Assert.Equal(state, rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.South, rover.CurrentState.FacingTo);
        }

        [Fact]
        public void Rover_InitializationToWestIsCorrect()
        {
            // Arrange
            var state = new WestState();
            var rover = new Rover(0, 0, state);

            //Assert
            Assert.NotNull(rover);
            Assert.NotNull(state);
            Assert.Equal(0, rover.X);
            Assert.Equal(0, rover.Y);
            Assert.Equal(state, rover.CurrentState);
            Assert.Equal(CardinalCompassPoint.West, rover.CurrentState.FacingTo);
        }
      
    }

}