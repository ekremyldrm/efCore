namespace App8.Entities
{
    public class Kargo  : BaseEntities
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public virtual List<Siparis>  Siparis { get; set; }
    }
}