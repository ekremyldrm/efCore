namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                   EfCore Configurasyon..
             */
            NorthDbContext _dbContext = new NorthDbContext();
            // Bu yöntem için  alltaki yorum satırlarını açınız ve ktList satırı ve sonrasını yorum satırı yapınız. 
            // Aynı zamanda dbcontext sınıfı içerisinde Kats1 üyesini açınız ve Kats2 üyesini yorum satırı yapınız...
            //var k1List = _dbContext.Kats1.ToList();
            //foreach (var k1 in k1List)
            //    Console.WriteLine($"{k1.CatID} \t {k1.Name} \t{k1.Desc}");
            Console.WriteLine("*******************************");
            Console.WriteLine("*****");
            Console.WriteLine("*************");
            Console.WriteLine("*********************");

            var k2list = _dbContext.Kats2.ToList();
            foreach (var k2 in k2list)
                Console.WriteLine($"{k2.CatID} \t {k2.Name} \t {k2.Desc}");
        }
    }
}
