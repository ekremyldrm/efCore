using System.Data;
using System.Data.SqlClient;

namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                SqlConnection (uygulama ile application arasında kanal görevi görür)

                SqlCommand (C# ortamında sql queryleri yazmak için kullanılır...)
                        -ExecuteReader (veri okumak için kullanılır)
                        -ExecuteScalar (fonksiyonları çağırmak için kullanılır)
                        -ExecuteNoneQuery ( insert,update,delete için kullanılır...
             */

            SqlConnection cnn = new SqlConnection("Server=.;Database=Northwind;uid=sa;pwd=321");
            cnn.Open();
            // bağlantı durumu
            //ConnectionState c = cnn.State;
            if(cnn.State == ConnectionState.Open)
            {
                Console.WriteLine("Bağlantı açıldı");
            }

        }

    }
}
