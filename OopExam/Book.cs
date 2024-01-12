

abstract class Book 
{
    public string? Title { get; set; }
    public string? Author { get; set; }

    protected  Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

 
}
