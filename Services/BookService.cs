public class BookService : IBookService
{
    public List<Book> _books;    
    
    public BookService()
    {        
        _books = new List<Book>();
        SeedData();
    }

    public Book GetById(int id)
    {
        return _books.FirstOrDefault(book => book.Id == id);
    }

    public List<Book> GetAll()
    {
        return _books;
    }

    public Book Create(Book book)
    {
        book.Id = _books.Count + 1;
        _books.Add(book);
        return book;
    }

    public Book Update(int id, Book book)
    {
        var existingBook = _books.FirstOrDefault(b => b.Id == id);
        if (existingBook != null)
        {
            existingBook.Title = book.Title;
            existingBook.Pages = book.Pages;
        }
        return existingBook;
    }

    public void Delete(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            _books.Remove(book);
        }
    }

    private void SeedData()
    {
        var book1 = new Book
        {
            Id = 1,
            Title = "Book 1",
            Pages = new List<Page>
            {
                new Page { PageNumber = 1, Content = "Page 1 Content" },
                new Page { PageNumber = 2, Content = "Page 2 Content" },
                new Page { PageNumber = 3, Content = "Page 3 Content" }
            }
        };

        var book2 = new Book
        {
            Id = 2,
            Title = "Book 2",
            Pages = new List<Page>
            {
                new Page { PageNumber = 1, Content = "Page 1 Content" },
                new Page { PageNumber = 2, Content = "Page 2 Content" },
                new Page { PageNumber = 3, Content = "Page 3 Content" }
            }
        };

        _books.Add(book1);
        _books.Add(book2);
    }
}
