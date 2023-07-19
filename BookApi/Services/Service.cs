using BookApi.Model;
using System.Data.Entity;

namespace BookApi.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _repository;

        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book FindBookById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Book> FindAllBooks()
        {
            return (List<Book>)_repository.GetAll();
        }

        public void CreateBook(Book book)
        {
            _repository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.Update(book);
        }

        public void DeleteBook(int id)
        {
            _repository.Delete(_repository.GetById(id));
        }
    }
}
