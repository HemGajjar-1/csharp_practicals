namespace ISP;
class InitialClass
{
    public static void Main(String[] args)
    {
        Book b1 = new Book() { BookId = 001, BookName = "Harry Potter" };
       
        // Here librarian can have full access
        Librarian p1 = new Librarian();
        p1.AddBook(b1);
        p1.SearchBook("Harry Potter");
        p1.BorrowBook(001, "Harry Potter");
        
        // Here guest can only search the book
        Guest p2 = new Guest();
        p2.SearchBook("Harry Potter");
        
        // Here member can search book and manage inventory
        Member p3 = new Member();
        p3.BorrowBook(001, "Harry Potter");
        p3.SearchBook("Harry Potter");
    }
}