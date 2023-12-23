using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()

            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

            void InterfacesIntro()
            {
                PersonManager manager = new PersonManager();
                manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
                Student student = new Student
                {
                    Id = 1,
                    FirstName = "Derin",
                    LastName = "Demiroğ",
                    Departman = "Computer Sciences",
                };
                manager.Add(student);
                manager.Add(new Worker { Id = 1, FirstName = "Ali", LastName = "Öksüz", Departman = "Elazığ" });
            }

            void Demo()
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(new SqlServerCustomerDal());
                customerManager.Add(new OracleServerCustomerDal());
                customerManager.Delete(new MySqlServerCustomerDal());
            }
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departman { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departman { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
