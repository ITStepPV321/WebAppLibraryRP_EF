using System.ComponentModel.DataAnnotations;

namespace WebAppLibraryRP_EF.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(1)]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Style { get; set; }
        public string PublishHouse { get; set; }
        [Range(0, 3000)]
        public int PublishYear { get; set; } = DateTime.Now.Year;
    }
}
/*
    ідентифікатор, назва книги; П.І.Б. автора, стиль; видавництво; рік видання. 
 
 */