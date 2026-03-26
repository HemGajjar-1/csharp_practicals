using ISP.Models;

namespace ISP.Interfaces;

internal interface IManageInventory
{
    void AddBook(Book book);
    void RemoveBook(int id);
}
