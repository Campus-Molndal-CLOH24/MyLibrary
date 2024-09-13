namespace MyProgram

{
    public class Book
{
    // Egenskap bokens titel
    public string Title { get; set; }
    // Egenskap författare
    public string Author { get; set; }
    // Egenskap för publiceringsår
    public int PublicationYear { get; set; }
    // Antal sidor
    public int PageCount { get; set; }
    // ISBN
    public string ISBN { get; set; }

    public Book(string title, string author, int publicationYear, int pageCount, string isbn)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        PageCount = pageCount;
        ISBN = isbn;
    }

    // Returnerar information om boken
    public string GetBookDetails()
    {
        return $"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Pages: {PageCount}, ISBN: {ISBN}";
    }
        

}
    }

