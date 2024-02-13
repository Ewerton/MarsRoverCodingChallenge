using MarsRoverCodingChallenge;
using MarsRoverCodingChallenge.RoverState;

public class Program
{
    static void Main(string[] args)
    {
        // Test input
        int plateauX = 5;
        int plateauY = 5;

        Console.WriteLine("Plateau size is 5 x 5 ");

        Rover rover1 = new Rover(1, 2, new NorthState());
        rover1.TurnLeft();
        rover1.Move();
        rover1.TurnLeft();
        rover1.Move();
        rover1.TurnLeft();
        rover1.Move();
        rover1.TurnLeft();
        rover1.Move();
        rover1.Move();

        Rover rover2 = new Rover(3, 3, new EastState());
        rover2.Move();
        rover2.Move();
        rover2.TurnRight();
        rover2.Move();
        rover2.Move();
        rover2.TurnRight();
        rover2.Move();
        rover2.TurnRight();
        rover2.TurnRight();
        rover2.Move();

        Console.WriteLine(rover1); // Output: 1 3
        Console.WriteLine(rover2); // Output: 5 1

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}