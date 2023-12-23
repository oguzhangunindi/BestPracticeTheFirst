using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();
            database.add();
            database.Delete();
            Console.ReadLine();
        }
        abstract class Database //Abstract Classlarda inheritance tek bir adet olur fakat interfaceler birden fazla inheritance edilebilirler
        {
            public void add()
            {
                Console.WriteLine("Added by default");
            }
            public abstract void Delete();

        }
        abstract class Database2 //Abstract Classlarda tanımlanması tamamlanmış methodlar ve virtual methodlar tanımlanabilirler.
        {
            public void add()
            {
                Console.WriteLine("Added by default");
            }
            public abstract void Delete();

        }
        class SqlServer : Database 
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Sql");
            }
        }
        class OracleServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Oracle");
            }
        }
    }
}
