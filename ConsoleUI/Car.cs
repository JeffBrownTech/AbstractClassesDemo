using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public bool HasTrunk { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("I'm driving from the override method in the Car class! 🚗");
    }
}
