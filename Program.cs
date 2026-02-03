class Program
{
    static void Main()
    {
        Library library = SaveSystem.Load();

        library.AddBook(new Book("Hobitti", "Tolkien"));
        library.AddBook(new Book("1984", "George Orwell"));

        library.BorrowBook("1984");

        SaveSystem.Save(library);
    }
}
