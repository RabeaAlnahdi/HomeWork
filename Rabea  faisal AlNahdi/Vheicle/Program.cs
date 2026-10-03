using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vheicle
{
    class Vehicle
    {
        public string Brand { get; }
        public int Year { get; }
        public void start()
        {
            Console.WriteLine("Vehicle started");
        }
        public Vehicle(string Brand, int Year)
        {
            this.Brand = Brand;
            this.Year = Year;
        }

    }
    class Car : Vehicle
    {
        public int NumberOfDoor { get; }

        public Car(string Brand, int Year, int NumberOfDoor) : base(Brand, Year)
        {
            this.NumberOfDoor = NumberOfDoor;
        }
    }

    class Bus : Vehicle
    {
        public int Capacity { get; }

        public Bus(string Brand, int Year, int Capacity) : base(Brand, Year)
        {
            this.Capacity = Capacity;
        }
    }

    class Motorcycle : Vehicle
    {
        public bool HasSidCar { get; }

        public Motorcycle(string Brand, int Year, bool HasSidcar) : base(Brand, Year)
        {
            this.HasSidCar = HasSidcar;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car("GMC", 2007, 4);
            c1.start();
            Console.WriteLine($" Car \n Brand : {c1.Brand} \n Year : {c1.Year} \n Number Of Door : {c1.NumberOfDoor} \n");
            Bus b1 = new Bus("Mercedes ", 2024, 25);
            b1.start();
            Console.WriteLine($"Bus \n Brand : {b1.Brand} \n Year : {b1.Year} \n Capacity : {b1.Capacity}\n");
            Motorcycle m1 = new Motorcycle("suzuki", 2026, false);
            m1.start();
            Console.WriteLine($"Motorcycle \n Brand : {m1.Brand} \n Year : {m1.Year} \n  Hss Sid Car : {m1.HasSidCar}");



        }
    }
}
