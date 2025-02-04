namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindDbContext northwindDbContext = new NorthwindDbContext();
            var katList = northwindDbContext.Kategori.ToList();
            foreach (var kat in katList) {
                Console.WriteLine($"{kat.KategoriId} {kat.KategoriAdi} {kat.Aciklama}");
            }

        }
    }
}
