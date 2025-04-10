

Book book = new Book(1, "Book Title", "Book Author", 100);
BookProxy bookProxy = new BookProxy(book);
Client client = new Client(bookProxy);

await client.GetBookDetails(1);
await client.GetBookDetails(1); // This time it should fetch from the proxy.
await client.GetBookDetails(2);
await client.GetBookDetails(3);
