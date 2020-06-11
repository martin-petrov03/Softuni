namespace BookShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AuthorBook
    {
        [Key]
        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [Required]
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
