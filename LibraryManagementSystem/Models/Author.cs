namespace LibraryManagementSystem.Models
{
   
    public class Author
    {
        public int Id { get; set; } //Yazar Kimliği (Primary Key)
        public string FirstName { get; set; } //Yazar Adı
        public string LastName { get; set; } //Yazar Soyadı
        public DateTime DateOfBirth { get; set; } //Doğum Tarihi
        public List<Book> Books { get; set; } = new(); //Yazarın Kitapları
    }
}
