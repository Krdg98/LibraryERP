namespace LibraryERP.Entity
{
    public class BookModel
    {
        


        public int Id { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public DateTime YearOfPublication { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }


    }
}
