using System;


namespace HomeWorkBook
{
    class Author
    {
        readonly string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Author: " + author);
        }
    }
}
