using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            //
            HandleException(() =>    //Bu ()=>{} süslü parantezin içerisinde parametresiz bir method'u parametre olarak kullanmak yaptığımız tanımlama
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action) //Action türünden tanımlama yaparsak parametre olarak method kullanabiliriz. HandleException delegasyonunu her kod için ayrı ayrı try catch yazmamak için kullandık. Tek sefer yazılan bu kod her koda uygulanıp her yere try catch atmamamızı sağlıyor.
        {
            try
            {
                action.Invoke(); //Invoke o methodu çalıştır anlamına geliyor.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };
            students.Contains("Ahmet");
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
                Console.WriteLine("Recod Found!");
        }

        private static void ExceptionIntro()
        {
            try
            {
                // string[] students = new string[3] { "Engin", "Derin", "Salih" };
                //students[3] = "Ahmet";
                int a = 10;
                int b = 0;
                int c = a / b;


            }
            catch (IndexOutOfRangeException exception) //Index'in sınırı aşması durumunda çalışa hata.
            {

                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception) //Elimizdeki verinin sıfıra bölünmeye çalışıldığında çalışan hata.
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
