using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); //dictionary koleksiyonu ise index yerine bizim verdiğimiz key değerler ile girdiğimiz verilerin bağlantısını sağlar.
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");
            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["computer"]);
            foreach (var item in dictionary) 
            {
                Console.WriteLine(item.Value+" "+item.Key);
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.ReadKey();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); //Type Secure olarak yani veri türünü parametre olarak vererek oluşturduğumuz List<> sadece tek tür değişkenleri içerir.
            cities.Add("Ankara");
            cities.Add("İstanbul");
            Console.WriteLine(cities.Contains("Ankara")); //Contains girilen değerin liste içerisinde olup olmadığına bakar var ise true yok ise false değerini döner.
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Engin" },
                new Customer { Id = 2, Name = "Derin" }
            };
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "Engin" });
            //customers.Add(new Customer { Id = 2, Name = "Derin" });
            var customer1 = new Customer
            {
                Id = 3,
                Name = "Salih"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2] //AddRange bir dizi veya listeyi kullandığımız List<> koleksiyonuna eklemek için kullanılır.
            {
                new Customer{Id=4,Name="Ali" },
                new Customer{Id=5,Name="Ayşe"}
            });
            Console.WriteLine(customers.Contains(customer1));
            // customers.Clear();
            var index = customers.IndexOf(customer1); //indexi taramaya listenin sonundan baştan başlar.
            Console.WriteLine("index : {0}", index);
            customers.Add(customer1);
            var index2 = customers.LastIndexOf(customer1); //indexi taramaya listenin sonundan başlar.
            Console.WriteLine("index : {0}", index2);
            customers.Remove(customer1); // Bulduğu ilk değeri siler ve işlemi bitirir. Listede aynı değerden birden fazla olsa dahi ilk bulduğunu siler ve işlemi bitirir.
            customers.RemoveAll(c => c.Name == "Salih"); //İsmi Salih olan tüm değerleri siler.
            customers.Insert(0, customer1); // Listede istediğimiz yere değeri eklememizi sağlar. İlk girdiğimiz parametre listedeki index numarası ikinci parametrede ekleyeceğimiz değerdir. Bu sayede listenin istediğimiz indexine veriyi eklemiş oluruz. Örneğin en başa değeri eklersek diğer eski değerlerin hepsi bir tık sağa kayarlar. 0 indexine eklediğimiz için 0 indexindeki değer 1 indexine geçer ve tüm değerler bu şekilde kayarlar.
            var count = customers.Count;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList(); //Birden fazla türde veri üzerinde çalışılacak ise ArrayList kullanılır. Parametre olarak almak istediği değer object türündendir ve object türüde yazılımda tüm değişkenlerin base türüdür. Bu sayede tüm değişken türlerini tek bir listede barındırabiliriz. 
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(cities[2]);
            Console.ReadKey();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
