using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Title
    {

        private string titleBook;
        public string TitleBook
        {
            get
            {
                return titleBook;
            }
            set
            {
                titleBook = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Book title: " + TitleBook);
            Console.WriteLine();
        }
    }
}
