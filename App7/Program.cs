using App7.Entities;

namespace App7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EF CORE MIGRATION
            // CODE FİRST YÖNTEMİ KULLANARAK VERİTABANINI YÖNETMEK  (OLUŞTURMAK,DÜZENLEMEK) İÇİN KULLANILIR
            //EF CORE İLE KOD  VERİTABANINA YANSITILIR. REFERANS NOKTASI C# KODLARIDIR. MİGRATİON İLE VERİTABANLARIMIZIN SCHEMALARINI OLUŞTURABİLİR, HİSTORYİSİNİ (VERSİYONLAMAK) TUTABİLİRSİNİZ..

            // add-migration MigrationName => migration oluşturulur. koddaki yapıa göre sql scheması oluşturulur...

            // update-database = oluşturulan schema veritabanına yansıtılır..

            // remove-migration => oluşturulan bir migration silinebilir...


            // Migration işlemi için ;
            // 1. Manage Nuget Packge  penceresinden Microsoft.EntityFrameworkCore.Tools packagesini indirmemiz gerekiyor...

            // 2. Tools menüsünden Package Manager Console Pencerisini açmamız gerekiyor...
            // Package Manager Console bu pencereyi kullanarak projenize packageler dahil edebilirsiniz...

            // Tools > Nuget Package Manager > Package Manager Console

            // Not bu pencerede Default project sekmesinden çalıştığunuz projeyi seçmeyi unutmayın..

            AppDbContext dbContext = new AppDbContext();
            var list = dbContext.Kategories.ToList();

        } 
    }
}
