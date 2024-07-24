using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public Car()
    {
        
    }

    public bool HasTrunk { get; set; } = true;

    public override void DriveAbstract()
    {
        Console.WriteLine("The Car is in drive"); 
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($"This {GetType().Name} is a virtually in drive {GetType().BaseType.Name}");
    }
}