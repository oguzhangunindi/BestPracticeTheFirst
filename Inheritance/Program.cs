using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"},
                new Student{FirstName="Derin"},
                new Person{FirstName="Salih"}
            };
            foreach (Person person in persons) 
            {
                Console.WriteLine(person.FirstName);            
            }
            Customer ahmet =new Customer();
            Console.ReadKey();
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person
        {
            public string City { get; set; }

        }
        class Student : Person
        {
            public string Departman { get; set; }

        }
                
    }
}
