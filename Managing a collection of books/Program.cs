namespace Managing_a_collection_of_books
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            static void Main(string[] args)
            {
                Book bookToAdd = new Book("", "", 1);

                List<Book> BookList = new List<Book>();


                Console.WriteLine("pleas write the books Title");
                bookToAdd.Title = Console.ReadLine()!;

                Console.WriteLine("pleas write  the books Author");
                bookToAdd.Author = Console.ReadLine()!;

                Console.WriteLine("pleas write the books YearPublished ");
                bookToAdd.YearPublished = Convert.ToInt32(Console.ReadLine()!);

                BookList.Add(bookToAdd);
                foreach (Book book in BookList)
                {
                    Console.WriteLine(book.Title);

                }



                Book book1 = new Book("See", "Tom", 1);
                Book book2 = new Book("Car", "Lee", 2);
                Book book3 = new Book("Pia", "Jane", 3);

                BookList.Add(book1);
                BookList.Add(book2);
                BookList.Add(book3);

                Console.Write("\nEnter title to search: ");
                string searchTitle = Console.ReadLine();
                SearchBookByTitle(searchTitle, BookList);
                Console.ReadKey();
                static void SearchBookByTitle(string titleToSearch, List<Book> BookList)
                {
                    var foundBook = BookList.Find(b => b.Title.ToLower() == titleToSearch.ToLower());
                    if (foundBook != null)
                    {
                        Console.WriteLine($"Found book: Title: {foundBook.Title}, Author: {foundBook.Author}, Year Published: {foundBook.YearPublished}");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
        }
    }
 }

