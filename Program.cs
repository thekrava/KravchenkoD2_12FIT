using System;

namespace KravchenkoD1_12FIT
{
    // Task #1 
    class Adress
    {
        string index;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }

        }

        private string country;
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }

        string city;
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }

        string street;
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }

        string house;
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }

        string apartament;
        public string Apartament
        {
            set
            {
                apartament = value;
            }
            get
            {
                return apartament;
            }
        }

        public string LINE
        {
            get
            {
                return new string('-', 30);
            }
        }
    }


    // Task2
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public Rectangle() { }

        double AreaCalculator()
        {
            return side1 * side2;
        }

        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area { get { return this.AreaCalculator(); } }
        public double Perimeter { get { return this.PerimeterCalculator(); } }
    }

    // Task 4 

    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Enter a letter of Point:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }

    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("enter number of verticles of your figure");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
}
// Done