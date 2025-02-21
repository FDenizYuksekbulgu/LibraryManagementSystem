using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;


namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        //Geçici veri olarak yazarları tutan static liste
        private static List<Author> authors = new List<Author>
        {
            new Author { Id = 1, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) }
        };

        //Yazarları listeleme
        public IActionResult List()
        {
            return View(authors);
        }

        //Yazar detaylarını gösterme
        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();
            return View(author);
        }

        //Yeni yazar ekleme sayfasını açma
        public IActionResult Create()
        {
            return View();
        }

        //Yeni yazar ekleme işlemi
        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                author.Id = authors.Count + 1; //Yeni yazarın ID'sini belirle
                authors.Add(author);
                return RedirectToAction("List");
            }
            return View(author);
        }

        //Yazar düzenleme sayfasını açma
        public IActionResult Edit(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();
            return View(author);
        }

        //Yazar düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(Author updatedAuthor)
        {
            var author = authors.FirstOrDefault(a => a.Id == updatedAuthor.Id);
            if (author != null)
            {
                author.FirstName = updatedAuthor.FirstName;
                author.LastName = updatedAuthor.LastName;
                author.DateOfBirth = updatedAuthor.DateOfBirth;
                return RedirectToAction("List");
            }
            return View(updatedAuthor);
        }

        //Yazar silme onay sayfası
        public IActionResult Delete(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();
            return View(author);
        }

        //Yazarı silme işlemi
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
            {
                authors.Remove(author);
            }
            return RedirectToAction("List");
        }
    }
}
