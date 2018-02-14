using System;


namespace HomeWorkBook
{
    class Content
    {
        readonly string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Content: " + content);
        }
    }
}
