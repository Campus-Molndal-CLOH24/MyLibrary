namespace MyProgram

{
    // KOD FÖR LIBRARY
    public class Library
{
    // Skapa en lista med böcker
    private List<Book> myBooks = new List<Book>();

    // Lägg till bok
    public void AddBook(Book newBook)
    {
        myBooks.Add(newBook);

        // Utskrift för att visa att boken har lagts till
        Console.WriteLine($"Title: {newBook.Title}");
        Console.WriteLine($"Author: {newBook.Author}");
        Console.WriteLine($"Publication Year: {newBook.PublicationYear}");
        Console.WriteLine($"Pages: {newBook.PageCount}");
        Console.WriteLine($"ISBN: {newBook.ISBN}");
        Console.WriteLine(); //Tomt mellan () ger radbrytning efter varje kluster Title-ISBN 
    }
    //Metod för att ta bort bok
    
    public bool RemoveBook(string title)
    {
        Book bookToRemove = myBooks.Find(book => book.Title == title);

        if (bookToRemove != null) // Om "BookToRemove" inte är "inget"(null) 
        {
            myBooks.Remove(bookToRemove); // Tar bort boken om den hittas
            return true; // returnera true om den tagits bort
        }
        return false; // returnera false om ingen bok tagits bort
    }

    // Hitta bok baserat på titel
    public Book FindBook(string title)
    {
        foreach (Book book in myBooks) // Går igenom alla böcker i listan
        {
            if (book.Title.ToLower() == title.ToLower()) // Om titeln stämmer, returnera boken oavsett om vi söker på gemener eller versaler 
            {
                return book;
            }
        }
        return null; // Boken hittas inte null avser tomt värde/ogiltig referens dvs inget finns att returnera 
    }
}
    }

