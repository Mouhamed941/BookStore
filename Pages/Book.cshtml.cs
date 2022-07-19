using BookStore.Models;
using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class BookModel : PageModel
    {   
        public List<Book> books = new ();

        [BindProperty]
        public Book NewBook  { get; set; } = new Book();
        public void OnGet()
        {
             books = BookService.GetAll();
        }
        public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                BookService.Add(NewBook);
                return RedirectToAction("Get");
            }
        
        
        public IActionResult OnPostDelete(int id)
            {
                BookService.Delete(id);
                return RedirectToAction("Get");
            }
        
    }
}
