using System.Data.SqlClient;

namespace Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server=.;Database=Northwind;uid=sa;pwd=321";

            SqlCommand cmd = new SqlCommand("select CategoryId,CategoryName from Categories");
            cmd.Connection = cnn;

            cnn.Open();
            
            SqlDataReader rdr = cmd.ExecuteReader();

            // Category bir veri sınıdır...
            List<Category> list = new List<Category>();
            while (rdr.Read())
            {
                Category c = new Category();
                c.CategoryId = rdr.GetInt32(0);
                c.CategoryName = rdr.GetString(1);
                list.Add(c);
            }
            cnn.Close();
         
            foreach(var item in list)
            {
                Console.WriteLine($"{item.CategoryId} {item.CategoryName}");
            }

        }
    }
}
