using App8.Entities;

namespace App8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //AppDbContext db = new AppDbContext();
            //db.Dispose();


            // using ifadesi ile using scopleari arası çalışır. scope'tan çıkıldığında dispose edilir. tabi using blooğunu kullanabilmek için tipin IDisposable türemesi gerekir...

            using (AppDbContext db = new AppDbContext())
            {
            }

        }
    }
}
