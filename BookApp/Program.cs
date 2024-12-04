namespace BookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Book Library");

            List<Book> books = new List<Book>();
            while (true) 
            {
                Console.WriteLine("Do you want to add a book? (yes/no):");
                string response = Console.ReadLine();

                if(response == "no")
                    break;
                Book book = new Book();

                Console.WriteLine("Enter the title of the book." );
                 book.Title = Console.ReadLine();

                Console.WriteLine("Enter the author of the book.");
                book.Author = Console.ReadLine();

                Console.WriteLine("Enter the year of the book published.");
                book.Year= int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the description of the book.");
                book.Description = Console.ReadLine();

                books.Add(book);
                Console.WriteLine("Book added successfully!!"  );
            }
            Console.WriteLine("List of all books entered:"  );
            foreach (Book book in books)
            {
                book.Identity();
                Console.WriteLine(  );
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
