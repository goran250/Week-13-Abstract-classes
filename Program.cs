namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates missing or incomplete implementation
            Console.WriteLine("Abstract Classes & Abstract Methods");

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.ReadLine();
        }
    }

    // base class - abstract class
    abstract class Vehicle
    {
        public int speed = 0;

        // Regular method or Non-abstract method
        public void Go()
        {
            Console.WriteLine("This Vehicle is Moving");
        }
    }

    // subclasses of Vehicle
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 200;

    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;

    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;

    }
}
