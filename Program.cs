// abstract classes = modifier that indicates missing or incomplete implementation
namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes & Abstract Methods");

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //Vehicle vehicle = new Vehicle(); // Cannot create an instance of the abstract class 'Vehicle'

            car.Go();
            car.Stop();
            bicycle.Go();
            bicycle.Stop();
            boat.Go();
            boat.Stop();

            Console.ReadLine();
        }


        // base class - abstract class
        abstract class Vehicle
        {
            public int speed = 0;

            // Abstract method - must be implemented by subclasses
            public abstract void Stop(); // Abstract method - no implementation, must be implemented by subclasses

            // Regular method or Non-abstract method
            public abstract void Go();
 
        }

        // subclasses of Vehicle
        class Car : Vehicle
        {
            public int wheels = 4;
            int maxSpeed = 200;

            public override void Stop()
            {
                Console.WriteLine("The Car is stopped\n");
            }

            public override void Go()
            {
                Console.WriteLine("This car is moving");
            }
        }

        class Bicycle : Vehicle
        {
            public int wheels = 2;
            int maxSpeed = 50;

            public override void Stop()
            {
                Console.WriteLine("The bycýcle is stopped\n");
            }
            public override void Go()
            {
                Console.WriteLine("This bicycle is moving");
            }
        }

        class Boat : Vehicle
        {
            public int wheels = 0;
            int maxSpeed = 100;

            public override void Stop()
            {
                Console.WriteLine("The boat is stopped\n");
            }

            public override void Go()
            {
                Console.WriteLine("This boat is moving");
            }
        }
    }
}

 