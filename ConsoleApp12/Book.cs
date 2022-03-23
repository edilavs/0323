using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Book
    {
        public Book(int no, string name, double price, string genre) : base(no, name, price)
        {
            this.Genre = genre;
        }
        public string Genre;

    }
}
