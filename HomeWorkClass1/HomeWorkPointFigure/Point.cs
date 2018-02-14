using System;

namespace HomeWorkPointFigure
{
    class Point
    {
        private int x, y;
        private string name;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

    }
}
