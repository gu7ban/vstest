//using System;
//
//namespace TaskNamespace
//{
//    public interface IAnimal
//    {
//        void MakeSound();
//        void Move();
//    }
//    public class Dog : IAnimal
//    {
//        public void MakeSound()
//        {
//            Console.WriteLine("Dog sound: "+"hav-hav");
//        }
//        public void Move()
//        {
//            Console.WriteLine("Dog Move: "+"Dog runs");
//        }
//    }
//    public class Bird : IAnimal
//    {
//        public void MakeSound()
//        {
//            Console.WriteLine("Bird sound: "+"cik-cik");
//        }
//        public void Move()
//        {
//            Console.WriteLine("Bird move: "+"Bird flies.");
//        }
//    }
//
//    public interface IVehicle
//    {
//        void Start();
//        void Stop();    
//    }
//    public class Car : IVehicle
//    {
//        public void Start()
//        {
//            Console.WriteLine("Car status: "+"Car Started.");
//        }
//        public void Stop()
//        {
//            Console.WriteLine("Car status: "+"Car Stopped.");
//        }
//    }
//    public class Bike : IVehicle
//    {
//        public void Start()
//        {
//            Console.WriteLine("Bike status: " + "Bike Started.");
//        }
//        public void Stop()
//        {
//            Console.WriteLine("Bike status: " + "Bike Stopped.");
//        }
//    }
//   class Program
//    {
//        static void Main()
//        {
//            IAnimal dog = new Dog();
//            dog.MakeSound();
//            dog.Move();
//            Console.WriteLine("");
//
//            IAnimal bird = new Bird();
//            bird.MakeSound();
//            bird.Move();
//            Console.WriteLine("");
//
//            IVehicle car = new Car();
//            car.Start();
//            car.Stop();
//            Console.WriteLine("");
//
//            IVehicle bike = new Bike();
//            bike.Start();
//            bike.Stop();
//            Console.WriteLine("\nProgramin sonu.");
//        }
//    }
//}



