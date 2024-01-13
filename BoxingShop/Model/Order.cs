namespace BoxingShop.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string? JsonOrder { get; set; }       
        public DateTime CreateDate { get; set; } = DateTime.Now;     
        public decimal OrderSum { get; set; }
    }
}
