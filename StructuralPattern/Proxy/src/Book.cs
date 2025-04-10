public class Book(int id, string title, string author, int pages) : IBook
{
    public int Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public int Pages { get; set; } = pages;

    public async Task<Book> GetBookById(int id)
    {
        Console.WriteLine("Real: Getting book details...");
        await Task.Delay(1000);//calling database to fetch the book.
        return new Book(id, "Book Title", "Book Author", 100);
    }
}