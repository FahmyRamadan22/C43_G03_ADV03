using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if (book is not null)
                return $"Title: {book.Title}";

            return "Title is not found";
        }

        public static string GetAuthors(Book book)
        {
            if (book is not null)
                return $"Authors: {string.Join(", ", book.Authors)}";

            return "Authors are not found";
        }

        public static string GetPrice(Book book)
        {
            if (book is not null) /*if (book is { })*/
                return $"Price: {book.Price}";

            return "Price is not found";
        }
    }

}

