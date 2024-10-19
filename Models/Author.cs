namespace Craciun_Darius_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AuthorName => $"{LastName}, {FirstName}";
        public ICollection<Book>? Books { get; set; }
    }
}
