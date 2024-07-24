using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    
    public int Year { get; set; } = 0;
    public string Make { get; set; } = "Something generic";
    public string Model { get; set; } = "Something generic";

    public abstract void DriveAbstract(); // Abstract/ Stubbed out method

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"This {GetType().Name} is virtually in drive");
    }
}