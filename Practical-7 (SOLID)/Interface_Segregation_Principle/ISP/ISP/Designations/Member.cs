using ISP.Interfaces;

namespace ISP.Designations;

internal class Member : IBorrowReturn, ISearchable
{
    /// <summary>
    /// Member is borrowing book
    /// </summary>
    public void BorrowBook(int id, string name)
    {
        Console.WriteLine($"Member is borrowing the Book :: {id} - {name}");
    }

    /// <summary>
    /// Member is returning book
    /// </summary>
    public void ReturnBook(int id, string name)
    {
        Console.WriteLine($"Member is returning the Book :: {id} - {name}");
    }

    /// <summary>
    /// Member is searching book
    /// </summary>
    public void SearchBook(string name)
    {
        Console.WriteLine($"Member is searching the Book :: {name} ");
    }
}