class Library
{
    public List<Book> Books { get; set; } = new();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void BorrowBook(string title)
    {
        var book = Books.Find(b => b.Title == title && !b.IsBorrowed);
        if (book != null)
            book.IsBorrowed = true;
    }

    public void ReturnBook(string title)
    {
        var book = Books.Find(b => b.Title == title && b.IsBorrowed);
        if (book != null)
            book.IsBorrowed = false;
    }
}
