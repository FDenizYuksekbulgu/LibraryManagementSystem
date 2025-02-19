namespace LibraryManagementSystem.Models
{
    // Author Modeli
    public class Author
    {
        public int Id { get; set; } // Benzersiz Kimlik
        public string FirstName { get; set; } // Adı
        public string LastName { get; set; } // Soyadı
        public DateTime DateOfBirth { get; set; } // Doğum Tarihi
        public List<Book> Books { get; set; } = new(); // Yazarın Kitapları
    }
}
