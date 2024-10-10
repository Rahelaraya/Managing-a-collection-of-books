

namespace Managing_a_collection_of_books
{
    public class Book
    {
            public string Title { get; set; }
            public string Author { get; set; }
            public int YearPublished { get; set; }


            public Book(string title, string author, int yearPublished)
            {
                Title = title;
                Author = author;
                YearPublished = yearPublished;
            }
    }
    
}
