using App5.Entites;

namespace App5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EF COre Relation

            Console.WriteLine("Hangi Kategorinin productlarini görmek istersiniz????");

            int KatId = Convert.ToInt32(Console.ReadLine());

            var _dbContext = new NorthDbContext();
            
            // bu şekilde category'e göre productlara erişebildiğimiz aşağıdaki gibi Navigator property yardımıyla yine ilişkisel verilere erişebiliriz...
            var result = _dbContext.Products.Where(c => c.CategoryId == KatId).ToList();


            // Navigator property
            // id'si 1 olan category..
            var cat1 = _dbContext.Categories.Find(1); // Find pK üzerindne ilgili objeyi bulursa onun dönüş tipinde veri döner... Sadece key verilir. eğr birden fazla alan kullanılacaksa first,firstOrDefault,Single,SingleOrDefault metotları kullaınılır...

            // ilişki üzerinden categorynin productina erişiyoruz....
            var catt1Products = cat1.Products.ToList(); // ilgili nesnenin navigator propertysinnde ilişkili verileri çekilir...


            var cat2 = _dbContext.Categories.Find(2);


            // ilişki üzerinden categorynin productina erişiyoruz....
            var cat2Proudcts = cat2.Products.ToList();

            var tedarikciler = _dbContext.Tedarikcis.ToList();
            var ulkeyeGore = _dbContext.Tedarikcis.Where(c => c.Ulke == "UK").ToList();
            var ulkeVeSehir = _dbContext.Tedarikcis.Where(c => c.Ulke == "Japan" && c.City == "Tokyo").ToList();

            // where geriye her zaman liste tipinde döner...tek bir nesne dahi olsa tek elemanlı bir liste verir..
            var obj1 = _dbContext.Tedarikcis.Where(x => x.TedarikciId == 1);
            var obj2 = _dbContext.Tedarikcis.Where(x => x.TedarikciId == 1).FirstOrDefault(); // listenin içerisinde bir tanesini ver...

            var obj = _dbContext.Tedarikcis.Find(1); // tek bir nesne verir....
            var ulist = obj.Urunler.ToList();



        }
    }
}
