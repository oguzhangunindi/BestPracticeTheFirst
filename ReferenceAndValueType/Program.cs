using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);
            //int string double vb. değişkenler değer değişkenleridir ve bunlarda birbirleri içerisine atıldıklarında sahip oldukları değerleri aktarmış olurlar.
            string[] cities1 = new string[] { "Ankara", "Bursa", "Eskişehir" }; //Örneğin cities1 dizisinin referans numarası 101 olsun
            string[] cities2 = new string[] { "Bolu", "Kayseri", "Antalya" };//Örneğin cities2 dizisininde referans numarası 102 olsun
            // class list array vb. değişkenler ise referans değişkenleridir ve bunlarda birbirleri içerisine atıldıklarında sahip oldukları referans değerlerini aktarmış olurlar.
            cities2 = cities1; //Bu işlemi yaptığımızda cities2 dizisinin 102 referans numarası garbage collector tarafından silinir ve yerine cities1'in referans numarası olan 101 aktarılır. Bu sebeple cities1 ve cities2 dizilerinin verilerini tuttukları yer 101 referans numaralı alan yani aynı alan olduğundan dolayı cities1 dizisinde yapılan değişiklikler otomatik olarak cities2 dizisinide etkiler. Aynı şekilde cities2 dizisinde yapılacak değişikliklerde cities1 dizisini etkiler.
            cities1[0] = "Yalova";
            Console.WriteLine(cities2[0]);
            cities2[2] = "Hatay";
            Console.WriteLine(cities1[2]);
            Console.ReadKey();

        }
    }
}
