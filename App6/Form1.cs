using App6.Entites;
using Microsoft.EntityFrameworkCore;

namespace App6
{
    public partial class Form1 : Form
    {
        AppDbContext _dbContext;
        public Form1()
        {
            InitializeComponent();

            _dbContext = new AppDbContext();
        }

        private void btnShipperList_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = _dbContext.Shippers.ToList();
            listBox1.DisplayMember = "CompanyName"; // tablodan gelen alan
            listBox1.ValueMember = "ShipperID";

            //foreach(var item in _dbContext.Shippers.ToList())
            //{
            //    listBox1.Items.Add(item);
            //}
        }

        private void btnGoster1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue == null)
            {
                MessageBox.Show("Shipper Seçiniz");
                return;
            }


            int ShipperId = (int)listBox1.SelectedValue; // Value memberi verir
            MessageBox.Show(ShipperId.ToString());


            // tüm orderlari listele
            //var orderList = _dbContext.Orders.ToList();

            var orderList = _dbContext.Orders.Where(c => c.ShipVia == ShipperId).ToList();

            dataGridView1.DataSource = orderList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sadece shipperli getirir...
            List<Shipper> shipList = _dbContext.Shippers.ToList();

            // listenin ilk shipperini alalım....
            Shipper shipper = shipList.FirstOrDefault(c => c.ShipperID == 1); // ID'si 1 olan shipperi alıyoruz...

            // QUERY YAZARAK İLİŞKİLİ VERİERİ GETEBİLİRİZ. 
            List<Order> orders = _dbContext.Orders.Where(C => C.ShipVia == 1).ToList();

            // Navigation Properyler ile ilişkili verilere bu yöntemi kullanmadan erişebiliriz. 3 farklı yöntem ile bu işlemi gerçekleştirebiliriz
            // Lazy Loading
            // Egear Loding
            // Explict Loading (Araştırnız)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ilişkili verileri yükleme...lazy loading
            // navigation property ile ilişkili verilere erişmek için kullanılır. ilişkili veriler çağrıldığına getirilir...verinin tamamını getirmez navigation propery çağrılığında alt verilerel getirilir...

            // Manage Nuget Package penceresindne browse sekmesinden Microsoft.EntityFrameworkCore.Proxies package 'i uygulama dahil edilir...
            // DbContext sınıfımızda Onconfiguring metodunda UseLazyLoadingProxies() çağrılır...

            // Veritabanında sadece shipperlar getirilir..
            List<Shipper> shipList = _dbContext.Shippers.ToList(); 

            Shipper shipper = shipList.FirstOrDefault(c => c.ShipperID == 1);

            // bu satırda tekrar veritabanına giderek order tablosuna select yapılır...2 bağlantı yapıldı
            List<Order> ordes = shipper.OrderList; // EPER UseLazyLoadingProxies KULLANMADIYSAK İLİŞİKİ VERİLEİR GETİREMEYİZ...
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Verinin tamamı getirilir. join sorgusu gibi düşünün. Örnekte Shipper üzrine inclue metodu çağrılarak bu satırda Shippers ve Orderslarin getirilmesi sağlanır.  verinin tamamı getirilir..

            //_dbContext.Shippers.Include(c => c.OrderList).ToList() => queryini join yöntemi ile çağırır..

            // Include metodunu çağırabilmek için using bölümüne Microsoft.EntityFrameworkCore; kütüphanesinin eklenmesi gerekir...
            //List<Shipper> shippers = _dbContext.Shippers.Include("Orders").ToList();

            // shipper ve Orders tablounun verilerinin tamamanını getirir...
            List<Shipper> shippers1 = _dbContext.Shippers.Include(c => c.OrderList).ToList();
            Shipper shipper = shippers1.FirstOrDefault(c => c.ShipperID == 1);
            List<Order> ordes = shipper.OrderList; // Order için Inclue ile çağrılduğı için tekar veritabnına gidilmez..
        }
    }
}
