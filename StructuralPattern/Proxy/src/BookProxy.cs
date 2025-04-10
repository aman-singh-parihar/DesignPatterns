public class BookProxy(Book book) : IBook
{
    private Book _book = book;

    public Dictionary<int, Book> BookDetails { get; set; } = new Dictionary<int, Book>();
    public string Title => _book.Title;
    public string Author => _book.Author;
    public int Pages => _book.Pages;

    public async Task<Book> GetBookById(int id)
    {
        Console.WriteLine("Proxy: Checking access before getting book details...");
        if (BookDetails.TryGetValue(id, out var book))
        {
            Console.WriteLine("Proxy: Book details already fetched.");
            return book;
        }
        
        var fetchedBook = await _book.GetBookById(id);
        BookDetails.Add(id, fetchedBook);
        Console.WriteLine("Real+Proxy: Book details fetched and stored.");
        return fetchedBook;
    }
}