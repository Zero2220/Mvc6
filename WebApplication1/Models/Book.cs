namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal DiscountPercent { get; set; }

        public List<BookTag> BookTag { get; set; }

        public Genre Genre { get; set; }

        public bool StockStatus { get; set; }

        


    }
}
