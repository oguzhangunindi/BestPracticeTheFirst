using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySqlServer mySqlServer = new MySqlServer();
            OracleServer oracleServer = new OracleServer();
            sqlServer.Add();
            mySqlServer.Add();
            oracleServer.Add();
            Console.ReadKey();
        }
        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            public virtual void Delete() //virtual methodlar eğer bir değişiklik yapılmadan kullanılırsalar default değeri, override edilirsede istenilen değeri verir.
            {
                Console.WriteLine("Deleted by default");
            }

        }
        class SqlServer:Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by Sql Code");
            }
        }
        class MySqlServer:Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by MySql Code");
            }
        }
        class OracleServer:Database
        {
         
        }
    }

}
