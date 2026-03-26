namespace ISP.Interfaces;

internal interface IBorrowReturn
{
    void BorrowBook(int id, string name);
    void ReturnBook(int id, string name);
}
