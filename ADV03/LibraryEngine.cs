using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    public delegate string BookDelegate(Book book);

    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookDelegate fptr)
        {
            foreach (var book in books)
                Console.WriteLine(fptr(book));

        }

        public static void ProcessBooks02(List<Book> books, Func<Book, string> fptr)
        {
            foreach (var book in books)
                Console.WriteLine(fptr(book));
        }
    }
}
