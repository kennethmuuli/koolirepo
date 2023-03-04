using System.Numerics;
using static _03_Inheritance.Program;

namespace _03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var vehicle = new Vehicle();
            Vehicle bus = new Bus();
            var car = new Car();
            var airplane = new Airplane();

            //vehicle.Move();
            //vehicle.Stop();
            bus.Move();
            bus.Stop();
            car.Move();
            car.Stop();
            airplane.Move();
            airplane.Stop();
        }

    }

    public abstract class Vehicle
    {
        public string Name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine(GetType().Name + " moving");
        }

        public virtual void Stop()
        {
            Console.WriteLine(GetType().Name + " stopped");
        }
    }

    public class Bus : Vehicle
    {
        //public override void Move()
        //{
        //    // Meie endi loogika
        //    Console.WriteLine(GetType().Name + ": additional logic");
            
        //    // Kutsume baas klassi Move meetodit
        //    base.Move();
        //}

        public override void Move()
        {
            Console.WriteLine(GetType().Name + ": bus moves!");
        }

    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine(GetType().Name + " driving");
        }

    }

    public class Airplane : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine(GetType().Name + " flying");
        }
    }
}