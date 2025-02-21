using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;



namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        //Geçici veri olarak kitapları tutan static liste
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", AuthorId = 1, Genre = "Dystopian", PublishDate = new DateTime(1949, 6, 8), ISBN = "123456789", CopiesAvailable = 5 }
        };

        //Kitapları listeleme
        public IActionResult List()
        {
            return View(books);
        }

        //Kitap detaylarını gösterme
        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        //Yeni kitap ekleme sayfasını açma
        public IActionResult Create()
        {
            return View();
        }

        //Yeni kitap ekleme işlemi
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = books.Count + 1; //Yeni kitabın ID'sini belirle
                books.Add(book);
                return RedirectToAction("List");
            }
            return View(book);
        }

        //Kitap düzenleme sayfasını açma
        public IActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        //Kitap düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book != null)
            {
                book.Title = updatedBook.Title;
                book.Genre = updatedBook.Genre;
                book.PublishDate = updatedBook.PublishDate;
                book.ISBN = updatedBook.ISBN;
                book.CopiesAvailable = updatedBook.CopiesAvailable;
                return RedirectToAction("List");
            }
            return View(updatedBook);
        }

        //Kitap silme onay sayfası
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        //Kitabı silme işlemi
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
            return RedirectToAction("List");
        }
    }
}
