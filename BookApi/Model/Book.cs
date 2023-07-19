using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookApi.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<Page> Pages { get; set; }

        public Book(int id, string title, string author, List<Page> pages)
        {
            Id = id;
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
