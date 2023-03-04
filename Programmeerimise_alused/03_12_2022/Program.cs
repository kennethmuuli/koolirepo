using System;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
                var hen = new Hen("White!");
                hen.EggReady += Hen_EggReady;
                hen.Start();
            });

            Task.Run(() =>
            {
                var hen = new Hen("Brown!");
                hen.EggReady += Hen_EggReady;
                hen.Start();
            });

            Console.ReadLine();
        }

        private static void Hen_EggReady(string henName)
        {
            Console.WriteLine(DateTime.Now + " " + henName + " Egg!");
        }
    }

    public delegate void NewEggDelegate(string henName);

    public class Hen
    {
        private string _henName;

        public event NewEggDelegate EggReady;

        public Hen(string henName)
        {
            _henName = henName;
        }

        public void Start()
        {
            for (var i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                EggReady.Invoke(_henName);
            }
        }
    }
}