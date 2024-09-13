
using System.Diagnostics;
using System.Threading.Channels;

namespace MyProgram

{

    // KOD FÖR PROGRAMMET

    public class Program
    {
        public static void Main(string[] args)
        {
            // Instans av biblioteket
            Library library = new Library();

            // Lägg till böcker
            library.AddBook(new Book("Nicke nyfiken", "Margret Reys", 2012, 24, "978-91-29-68034-8"));
            library.AddBook(new Book("Harlekins julklapp", "Hans Wilhelm", 1989, 26, "91-7904-411-5"));
            library.AddBook(new Book("Micke och Miranda", "Rina Dahlerup", 1984, 30, "91-510-4227-4"));
            library.AddBook(new Book("ABC resan", "Elsa Beskow",1945 , 30, "978-91-8094-092-4"));
            library.AddBook(new Book("Lejonkungen", "Disney", 1996, 44, "91-7707-331-2"));
            library.AddBook(new Book("Våra mest älskade sagor", "Tukan Förlag", 2015, 199, "978-91-7783-799-2"));



            // Hitta bok med hjälp av titel
            Console.WriteLine("Find book with title 'Nicke nyfiken'");//Testa att endast skriva *nicke*
            Book found = library.FindBook("Nicke nyfiken");

            if (found != null) 
            {
                Console.WriteLine("Book found");
                Console.WriteLine(found.GetBookDetails());
            }
            else
            {
                Console.WriteLine("Book not found");
            }

            // Ta bort bok med hjälp av titel
            Console.WriteLine("Remove book with title 'Harlekins julklapp'");
            bool removed = library.RemoveBook("Harlekins julklapp");

            if (removed)
            {
                Console.WriteLine("Book removed");
            }
            else
            {
                Console.WriteLine("Book could not be removed");
            }
        }
               
        }       
    }

