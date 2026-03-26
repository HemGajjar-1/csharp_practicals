using ISP.Interfaces;

namespace ISP.Designations;

internal class Guest : ISearchable
{
    /// <summary>
    /// Guest is searching book
    /// </summary>
    public void SearchBook(string name)
    {
        Console.WriteLine($"Guest is searching the Book :: {name} ");
    }
}
