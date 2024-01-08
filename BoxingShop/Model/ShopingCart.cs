namespace BoxingShop.Model
{
    public class ShopingCart
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public int Size { get; set; }       
        public decimal Price { get; set; }
        public string? UrlImg { get; set; }
        public int CountProduct { get; set; } = 1;
    }

}

