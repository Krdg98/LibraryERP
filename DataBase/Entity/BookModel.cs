using System.ComponentModel.DataAnnotations;

namespace LibraryERP.DataBase.Entity
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public DateTime YearOfPublication { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}
