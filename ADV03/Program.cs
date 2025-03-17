namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = [
               new Book("11", "Rich Dad Poor Dad" , ["Robert Kiyosaki"], new DateTime(1997, 4, 1), 100.0),
                new Book("22", "Atomic Habits" , ["James Clear"], new DateTime(2018, 10, 16), 200.0),
                new Book("33", "Youtopia", ["Ahmed Khaled Tawfik", "John Doe"], new DateTime(2019, 1, 1), 300.0)
               ];

            // 1. User-defined delegate

            BookDelegate getTitleDelegate = BookFunctions.GetTitle;
            BookDelegate getAuthorsDelegate = BookFunctions.GetAuthors;
            BookDelegate getPriceDelegate = BookFunctions.GetPrice;


            // 2. Built-in Func delegate

            Func<Book, string> getTitleFunc = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks02(books, getTitleFunc);


            // 3. Anonymous method (GetISBN)

            LibraryEngine.ProcessBooks02(books, delegate (Book book)
            {
                return $"ISBN: {book.ISBN}";
            });


            // 4. Lambda expression (GetPublicationDate)


            LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToString("D"));


            Console.WriteLine(5);


        }



    }
}

