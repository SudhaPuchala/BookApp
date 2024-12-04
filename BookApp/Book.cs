using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    internal class Book
    {
        public string Title;
        public string Description;
        public string Author;
        public int Year;


        public void Identity()
        {
            Console.WriteLine($"Title:{Title}");
            Console.WriteLine($"Description:{Description}");
            Console.WriteLine($"Year:{Year}");
            Console.WriteLine($"Author:{Author}");
        }

    }
}
