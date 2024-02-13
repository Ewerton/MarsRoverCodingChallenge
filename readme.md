# Mars Rover technical Challenge

The problem below requires some kind of input. You are free to implement any mechanism for feeding input into your solution (for example, using hard coded data within a unit test). You should provide sufficient evidence that your solution is complete by, as a minimum, indicating that it works correctly against the supplied test data.

We highly recommend using a unit testing framework such as JUnit or NUnit. Even if you have not used it before, it is simple to learn and incredibly useful.

The code you write should be of production quality, and most importantly, it should be code you are proud of.

## MARS ROVERS

A squad of robotic rovers are to be landed by NASA on a plateau on Mars.

This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth.

A rover's position is represented by a combination of an x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot.

'M' means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

Since the grid is rectangular and bounded (…yes Mars is a strange planet), a robot that moves “off” an edge of the grid is lost forever. However, lost robots leave a robot “scent” that prohibits future robots from dropping off the world at the same grid point. The scent is left at the last grid position the robot occupied before disappearing over the edge. An instruction to move “off” the world from a grid point from which a robot has been previously lost is simply ignored by the current robot.

### Input:

The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.

The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.

The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.

Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

### Output:

The output for each rover should be its final co-ordinates and heading.

**Test Input:**

`5 5`

`1 2 N`

`LMLMLMLMM`

`3 3 E`

`MMRMMRMRRM`

**Expected Output:**

`1 3 N`

`5 1 E`

See 
- [TestRover1](https://github.com/Ewerton/MarsRoverCodingChallenge/blob/main/RoverOnMarsTests/TestRover1.cs) Reproduces the movement of the **first** rover from the example input
- [TestRover2](https://github.com/Ewerton/MarsRoverCodingChallenge/blob/main/RoverOnMarsTests/TestRover2.cs) Reproduces the movement of the **second** rover from the example input


# Solution
Created a class library to represent the rovers and their movements, this way the "solution" can be provided to anyone who needs to move rovers around mars, or, anyone who need to provide some graphical representation of the rovers.
The class library is tested using xUnit.

## To do:
- [ ] Create a class to represent the plateau
  - [ ] Register when an rover
- [ ] Prevent rovers from going out of bounds
- [ ] Prevent rovers from colliding with each other
- [ ] Create a method to parse the input
