using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccessModifiers2
{
     class Program
    {
        static void Main(string[] args)
        {
            PublicCourse publicCourse = new PublicCourse();
            publicCourse.id = 1;
            Customer customer = new Customer();
            CourseManager cm = new CourseManager();
            cm.add();
        }
    }
}
