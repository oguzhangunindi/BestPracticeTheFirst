using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();
            customerManager.Add();
            //ILogger[] bulkLogger = new ILogger[2]
            //{
            //    new DatabaseLogger(),
            //    new FileLogger(),
            //};
            //foreach (var loggerItem in bulkLogger)
            //{
            //    loggerItem.Log();
            //}
            //customerManager.Add();
            Console.ReadKey();
        }
    }
    class CustomerManager
    {
        public ILogger logger { get; set; } //property injection
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
