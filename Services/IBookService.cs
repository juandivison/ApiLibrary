public interface IBookService
{
    Task<Book> GetByIdAsync(int id);
    Task<List<Book>> GetAllAsync();
    Task<Book> CreateAsync(Book book);
    Task<Book> UpdateAsync(int id, Book book);
    Task DeleteAsync(int id);
}