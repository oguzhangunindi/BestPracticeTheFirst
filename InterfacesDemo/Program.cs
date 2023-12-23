using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers) 
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach(var eat in eats) 
            {
                eat.Eat();
            }
            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach(IGetSalary getSalary in getSalaries)
            {
               getSalary.GetSalary();
            }
            Console.ReadKey();
        }
        interface IWorker
        {
            void Work();

        }
        interface IEat
        {
            void Eat();
        }
        interface IGetSalary
        {
            void GetSalary();

        }
        class Manager : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Müdür Yemeğini Ye");
            }

            public void GetSalary()
            {
                Console.WriteLine("Müdür Paranı Al");
            }

            public void Work()
            {
                Console.WriteLine("Müdür İşini Yap");
            }
        }
        class Worker : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Çalışan Yemeğini Ye");
            }

            public void GetSalary()
            {
                Console.WriteLine("Çalışan Paranı Al");
            }

            public void Work()
            {
                Console.WriteLine("Çalışan İşini Yap");
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot İşini Yap");
            }
        }

    }
}
