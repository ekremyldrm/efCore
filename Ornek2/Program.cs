using System.Data.SqlClient;

namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // System.Data.SqlClient kütüphanesini projeye dahil etmek için   Manage Nuget Package  penceresini kullanabiliriz. projemize sağ tık yaparak pencereye ulaşabiliriz.
            /*
                SqlDataReader  sınıfı verili ado.net ile okurken connectted mimaride bellekte tutmak ve okumak için kullanılınır... 
             */

            SqlConnection cnn = new SqlConnection("Server=.; Database=Northwind;uid=sa;pwd=321");

            //SqlCommand cmd = new SqlCommand("select CategoryId,CategoryName from Categories",cnn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryId,CategoryName from Categories";
            cmd.Connection = cnn;

            cnn.Open(); // DB BAĞLANTISINI AÇ

            SqlDataReader rdr = cmd.ExecuteReader(); // VERİLERİ OKU...
            while (rdr.Read()) // okunacak satır var ise true döner.. sıralı ile dönen resulti okur...
            {

                Console.Write(rdr.GetInt32(0)); // sıradaki satırın 0. sütununu oku ve ekrana yaz.
                Console.Write("\t");
                Console.Write(rdr.GetString(1));// sıradaki satırın 1. sütununu oku ve ekrana yaz.
                Console.WriteLine("");
            }
            cnn.Close(); // DB BAĞLANTISNI KAPAT

        }
    }
}
