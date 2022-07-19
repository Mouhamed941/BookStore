using BookStore.Models;
namespace BookStore.Services;

public static class BookService
{
    static List<Book> Books {get;}
    static int nextId = 3;

    static BookService()
    {
        Books = new List<Book>
        {
            new Book { Id = 1, Title = "Think And Grow Rich", PageCount = 300, PublishDate = new DateTime(1949,05,01)},
            new Book { Id = 2, Title = "Rich Dad Poor Dad", PageCount = 241, PublishDate = new DateTime(1997)}
        };
    }
    public static List<Book> GetAll() => Books;
    public static Book? Get(int id) => Books.FirstOrDefault(b => b.Id == id);
    public static void Add(Book book)
    {
        book.Id = nextId++;
        Books.Add(book);
    }
    public static void Delete(int id)
    {
        var book = Get(id);
        if (book is null)
            return;

        Books.Remove(book);
    }

    public static void Update(Book book)
    {
        var index = Books.FindIndex(p => p.Id == book.Id);
        if (index == -1)
            return;

        Books[index] = book;
    }
}