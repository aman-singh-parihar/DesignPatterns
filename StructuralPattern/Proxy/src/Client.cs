public class Client(IBook book)
{
    IBook _book = book;
    public async Task GetBookDetails(int id)
    {
        Console.WriteLine("Client: Requesting book details...");
        var bookDetails = await _book.GetBookById(id);
        Console.WriteLine($"Client: Book Id: {bookDetails.Id} Book Title: {bookDetails.Title}, Author: {bookDetails.Author}, Pages: {bookDetails.Pages}");
    }
}