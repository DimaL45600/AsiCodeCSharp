using System.Security.Cryptography;

namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Toyota", 142);
            Car c1 = new Car("Ford",187,3);
            SportCar sc1 = new SportCar("BMW", 340, 1);
            Console.WriteLine("____________________");
            Console.WriteLine(Vehicle.data);
            Vehicle.data = 25;
            v1.Drive();
            v1.Speed = 100;
            v1.Speed = 34;
            v1.Drive();
            Console.WriteLine("____________________");
            Console.WriteLine(Car.data);
            c1.Drive();
            c1.Speed = 155;
            c1.Speed = 3000;
            c1.Drive();
            Console.WriteLine("____________________");
            Console.WriteLine(SportCar.data);
            sc1.Drive();
            sc1.Speed = 380;
            sc1.Speed = 3000;
            sc1.Drive();
            Console.WriteLine("____________________All Cars_________________");
            Vehicle[] vehicles = { v1, c1, sc1 };
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Speed = 399;
                vehicle.Drive();
            }
            Console.WriteLine("____________________");
            Vehicle v3 = new SportCar("Alpina", 289, 2);
            SportCar v2 = (SportCar)v3;
            v2.Drive();
        }
    }
    public class Vehicle
    {
        public static int data = 10;
        protected string brand;
        protected int speed;
        public virtual int Speed { 
            get => speed;
            set
            {
                if(value >= 0 && value < 50)
                {
                    speed = value;
                } else
                {
                    Console.WriteLine("Incorrect speed!");
                }
            }
        }
        public Vehicle(string brand, int speed)
        {
            Console.WriteLine("Base");
            this.brand = brand;
            this.speed = speed;
        }
        public Vehicle()
        {
            brand = "Isuzu";
            speed = 50;
        }
        public virtual void Drive()
        {
            Console.WriteLine($"Vehicle ({brand}) is riding with speed {speed}km/h");
        }
    }
    public class Car : Vehicle
    {
        protected int passangerCount;
        public override int Speed 
        { 
            get => base.Speed; 
            set
            {
                if (value >= 0 && value < 240)
                {
                    speed = value;
                }
                else
                {
                    Console.WriteLine("Incorrect speed for car!");
                }
            } 
        }
        public Car(int passangerCount)
        {
            this.passangerCount = passangerCount;
        }
        public Car(string brand, int speed, int passangerCount) : base(brand,speed)
        {
            Console.WriteLine("Car");
            this.passangerCount = passangerCount;
        }
        public override void Drive()
        {
            Console.WriteLine($"Car ({brand}) is riding with speed {speed}km/h and {passangerCount} passangers");
        }
    }
    public class SportCar : Car
    {
        public new static int data = 55;
        public SportCar(string brand, int speed, int passangersCount) : base(brand, speed, passangersCount)
        {

        }
        public override int Speed
        {
            get => base.Speed;
            set
            {
                if (value >= 0 && value < 400)
                {
                    speed = value;
                }
                else
                {
                    Console.WriteLine("Incorrect speed for sport car!");
                }
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"Sport Car ({brand}) is riding with speed {speed}km/h and {passangerCount} passangers");
        }
    }
}
