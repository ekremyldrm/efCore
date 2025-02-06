
using App4.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fluent api configuration

            NorthwindDbContext dbContext = new NorthwindDbContext();


            //select  CompanyName from Shippers
            var nakliyeciler = dbContext.Nakliyecis.Select(c => c.Adi).ToList();

            // Ships Listesinin 
            // select ile birden fazla properyi alıyorsanız veya new ifadesi ile select yapıyorsanız bunlar için anonim bir tip oluşturur...
            var ships = dbContext.Nakliyecis.Select(c => new
            {
                c.Adi,
                c.TelNo,
            }).ToList();



             List<Nakliyeci> l1 = dbContext.Nakliyecis.Where(c => c.ID > 3).ToList();

            // select nnew ifadesinin yanında tip belirtirseniz  o tipte dönüş yaparsanız
            List<ekrem> list = dbContext.Nakliyecis.Where(c => c.ID > 3)
                .Select(c => new ekrem
                {
                    Name = c.Adi,
                    Phone = c.TelNo
                }).ToList();

            var kategoriler = dbContext.Kategoris.ToList();

            foreach (var item in nakliyeciler)Console.WriteLine(item);

            foreach (var item in ships) Console.WriteLine($"{item.Adi} {item.TelNo}");
        }
    }
}
