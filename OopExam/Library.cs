

 class Library : LibraryFunction
{
   private static List<Book> _books = new List<Book>();

    public void AddBook(string title, string author,  int type)
    {
        if(type == 1)
        {
            var saleBook = new SaleBook(title, author);
            _books.Add(saleBook);
        }
        if (type == 2)
        {
            var rentBook = new RentBook(title, author);
            _books.Add(rentBook);
        }
    }

    public void RemoveBook(string title)
    {
        foreach(Book book in _books)
        {
            if (book.Title == title)
            {
                _books.Remove(book);
            }
        }
    }

    public void RemoveBook()
    {
        throw new NotImplementedException();
    }

    public void ShowDetail()
    {
        foreach(var book in _books)
        {
            Console.WriteLine($"{book.Title} , {book.Author}");
        }
    }
}
