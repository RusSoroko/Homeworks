namespace BookPage.Models
{
    public class BookViewModel
    {
        public BookViewModel(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

    }
}
