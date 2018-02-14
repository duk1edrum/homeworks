namespace HomeWork1
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
             
                     
        // Периметр
        public double PerimetrCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Perimetr
        {
            get { return this.PerimetrCalculator(); }
        }


        //Площадь 
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double Area
        {
           get { return this.AreaCalculator(); }
        }
    }
}
