using System;


namespace HomeWorkBook
{
    class Title
    {
        readonly string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Title: " + title);
        }

    }
}
