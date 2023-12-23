using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccessModifiers
{
    public class Program
    {
        public static void Main(string[] args)
        {
    
        }
    }
    public class Customer
    {
        protected int id { get; set; }
        private int id2 { get; set; }
        public void save()
        {
            id = 5;
            id2 = 8;
        }
    }
    class Student : Customer
    {
        public void save()
        {
            id = 2; //Private ve protected türünde olan tanımlamalar sadece tanımlandıkları blok içerisinde erişilebilir olurlar.
                    //id2 = 3;//Fakat protected'ın private'ten en büyük farkı inheritance yolu ile erişilebilir olmasıdır. Private değerlere inheritance ile de erişilemez.
        }
    }
    internal class Course //Classların default değeri internal'dır. Örneğin:internal class Course
    {                    //internal o nesnenin sadece o proje içerisinde erişilebilir olduğunu bildirir. Yani o proje içerisindeki diğer classlar tarafından da erişilebilirler.
        public string Name { get; set; }

    }
    public class PublicCourse
    {
        public int id { get; set; }
    }
}
