namespace ISP.Designations;

internal class Librarian : IBorrowReturn, IManageInventory, ISearchable
{
    /// <summary>
    /// Librarian is borrowing book
    /// </summary>
    public void BorrowBook(int id, string name)
    {
        Console.WriteLine($"Librarian is borrowing the Book :: {id} - {name}");
    }

    /// <summary>
    /// Librarian is returning book
    /// </summary>
    public void ReturnBook(int id, string name)
    {
        Console.WriteLine($"Librarian is returning the Book :: {id} - {name}");
    }

    /// <summary>
    /// Librarian is adding book
    /// </summary>
    public void AddBook(Book book)
    {
        Console.WriteLine($"Librarian is adding the Book :: {book.BookId} - {book.BookName}");
    }

    /// <summary>
    /// Librarian is removing book
    /// </summary>
    public void RemoveBook(int id)
    {
        Console.WriteLine($"Librarian is removing the Book :: {id} ");
    }

    /// <summary>
    /// Librarian is searching book
    /// </summary>
    public void SearchBook(string name)
    {
        Console.WriteLine($"Librarian is searching the Book :: {name} ");
    }
}