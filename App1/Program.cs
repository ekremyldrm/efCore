namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Varolan bir tabanının tablosundaki verileri okuyalım....
            // Projemize sağ tık yaparak Manage Nuget Packages seçeneği ile Microsofot.EntityFramework.Core kütüphanesi projeye dahil edilir... 

            //1. Step projemize sağ  tık yapıp NorhwindDbContext isminde bir sınıf ekliyoruz...
            //2. Step veritabanımızdan çekeceğimiz tablo ile ilişkilendirilecek bir adet sınıf oluşturuyoruz. Categories tablosu için Categories sınıfı....


            NorhwindDbContext dbContext = new NorhwindDbContext();
            var kategoiler = dbContext.Categories.ToList();

            foreach (var category in kategoiler) {

                Console.WriteLine($"{category.CategoryID} -  {category.CategoryName}");
            }
        }
    }
}
