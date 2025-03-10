﻿namespace LibraryManagementSystem.Models
{
   
    public class Book
    {
        public int Id { get; set; } //Kitap Kimliği (Primary Key)
        public string Title { get; set; } //Kitap Başlığı
        public int AuthorId { get; set; } //Yazar Kimliği (Foreign Key)
        public string Genre { get; set; } //Kitap Türü
        public DateTime PublishDate { get; set; } //Yayın Tarihi
        public string ISBN { get; set; } //ISBNN Numarası
        public int CopiesAvailable { get; set; } // Mevcut Kopya Sayısı
       
    }
}
