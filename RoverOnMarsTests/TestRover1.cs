using MarsRover.RoverState;
using MarsRoverCodingChallenge.RoverState;
using MarsRoverCodingChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverOnMarsTests
{

    public class TestRoverMovements
    {
        private Rover _rover;
        private IRoverState _initialState;

        /// <summary>
        /// This function tests the following input:
        /// 5 5
        /// 1 2 N
        /// LMLMLMLMM
        /// The expected output is:
        /// 1 3 N
        /// </summary>
        [Fact]
        public void TestRover1Movement()
        {
            // Arrange
            _initialState = new NorthState();
            _rover = new Rover(1, 2, _initialState); // 1 2 N

            // Act
            _rover.TurnLeft(); // L
            _rover.Move(); // M
            _rover.TurnLeft(); // L
            _rover.Move(); // M
            _rover.TurnLeft(); // L
            _rover.Move(); // M
            _rover.TurnLeft(); // L
            _rover.Move(); // M
            _rover.Move(); // M

            // Assert
            Assert.Equal(1, _rover.X);
            Assert.Equal(3, _rover.Y);
            Assert.Equal(CardinalCompassPoint.North, _rover.CurrentState.FacingTo);
        }

        /// <summary>
        /// This class testes the following input:
        /// 3 3 E
        /// MMRMMRMRRM
        /// The expected output is:
        /// 5 1 E
        /// </summary>
        [Fact]
        public void TestRover2Movement()
        {
            // Arrange
            _initialState = new EastState();
            _rover = new Rover(3, 3, _initialState); // 3 3 E

            // Act
            _rover.Move(); // M
            _rover.Move(); // M
            _rover.TurnRight(); // R
            _rover.Move(); // M
            _rover.Move(); // M
            _rover.TurnRight(); // R
            _rover.Move(); // M
            _rover.TurnRight(); // R
            _rover.TurnRight(); // R
            _rover.Move(); // M           

            // Assert
            Assert.Equal(5, _rover.X);
            Assert.Equal(1, _rover.Y);
            Assert.Equal(CardinalCompassPoint.East, _rover.CurrentState.FacingTo);
        }
    }
}
