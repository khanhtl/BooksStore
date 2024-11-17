using BooksStore.Models;

namespace BooksStore.Services
{
    public class LocalBooksService : IBooksService
    {
        static List<Book> _allBooks = new List<Book>
         {
             new Book
             {
                 Id = "1",
                 AuthorName = "John Smith",
                 PublishingDate = new DateTime(2021, 01, 12),
                 Price = 25,
                 Title = "Blazor WebAssembly Guide"
             },
             new Book
             {
                 Id = "2",
                 AuthorName = "John Smith",
                 Price = 35,
                 PublishingDate = new DateTime(2022, 03, 13),
                 Title = "Mastering Blazor WebAssembly",
             },
             new Book
             {
                 Id = "3",
                 AuthorName = "John Smith",
                 Price = 45,
                 PublishingDate = new DateTime(2022, 08, 01),
                 Title = "Learning Blazor from A to Z"
             }
         };

        public Task<List<Book>> GetAllBooksAsync()
        {
            return Task.FromResult(_allBooks);
        }

        public Task<Book?> GetBookByIdAsync(string? id)
        {
            var book = _allBooks.SingleOrDefault(b => b.Id == id);
            return Task.FromResult(book);
        }
    }
}
