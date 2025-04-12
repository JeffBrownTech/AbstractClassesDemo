using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            var carOne = new Car
            {
                Year = "1995",
                Make = "Pontiac",
                Model = "Grand Am",
                HasTrunk = true
            };

            Vehicle carTwo = new Car()
            {
                Year = "2008",
                Make = "Toyota",
                Model = "Yaris",
                HasTrunk = false
            };

            var bikeOne = new Motorcycle()
            {
                Year = "2000",
                Make = "Yamaha",
                Model = "MLD3938",
                HasSideCart = false
            };

            Vehicle bikeTwo = new Motorcycle()
            {
                Year = "1985",
                Make = "Mokini",
                Model = "CXS9283",
                HasSideCart = false
            };

            vehicles.Add(carOne);
            vehicles.Add(carTwo);
            vehicles.Add(bikeOne);
            vehicles.Add(bikeTwo);

            Console.WriteLine("Year\tMake\tModel");
            Console.WriteLine("----\t----\t-----");

            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine($"{item.Year}\t{item.Make}\t{item.Model}");
            }

            carOne.DriveAbstract();
            carOne.DriveVirtual();
            

            bikeOne.DriveAbstract();
            bikeOne.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
