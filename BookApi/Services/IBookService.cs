using BookApi.Model;

namespace BookApi.Services
{
    public interface IBookService
    {
        Book FindBookById(int id);
        List<Book> FindAllBooks();
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
