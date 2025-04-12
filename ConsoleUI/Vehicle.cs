using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; } = "1900";
    public string Make { get; set; } = "VehicleMake";
    public string Model { get; set; } = "VehicleModel";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("I'm driving from the virtual method in the Vehicle abstract class!");
    }
}
