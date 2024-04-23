namespace WebApplication1.Models
{
    public class BookImage
    {
        public int Id { get; set; }

        public Book BookId { get; set; }

        public string Name { get; set; }

        public bool PosterStatus { get; set; }
    }
}
