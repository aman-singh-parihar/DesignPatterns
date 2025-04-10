public interface IBook
{
    string Title { get; }
    string Author { get; }
    int Pages { get; }

    Task<Book> GetBookById(int id);
}