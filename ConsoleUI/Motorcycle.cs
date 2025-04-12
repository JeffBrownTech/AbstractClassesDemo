using System;
using System.Runtime;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("I'm driving from the override abstract method in the Motorcycle class!  🏍️");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("I'm driving from the override virtual method in the Motorcycle class!  🏍️");
    }
}
