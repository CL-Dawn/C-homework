using assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            for (int i = 0;i<10;i++)
            {
                shapes.Add(ShapeFactory.CreateShape());
            }
            double totalArea = 0;
            foreach (Shape shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            Console.WriteLine(totalArea);
        }

    }

    
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract bool IsValid();
        
    }
    public class Circle :Shape
    {
        public Circle(double r)
        {
            if(r < 0)
            {
                throw new ArgumentException();
            }
            R = r;
        }

        public double R
        {
            get;
            set;
        }

        public override bool IsValid()
        {
            return R > 0 ;
        }
        public override double CalculateArea()
        {
            return Math.PI * R*R;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double edge1, double edge2, double edge3)
        {
            
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
        }

        public double edge1 { get; set; }
        public double edge2{ get; set; }
        public double edge3 { get; set; }

        public override bool IsValid()
        {
            return edge1>0&&edge2>=0&&edge3>=0&&edge1<edge2+edge3&&edge2 <edge1+edge3&&edge3 <edge1+edge2;
        }
        public override double CalculateArea()
        {
            double s=(edge1+ edge2+edge3)/2;
            return Math.Sqrt(s*(s-edge3)*(s-edge2)*(s-edge1));
        }
    }

    public class Rectangle : Shape 
    {
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double a  { get; set; }
        public double b { get; set; }

        public override bool IsValid()
        {
            return a > 0 && b > 0;
        }
        public override double CalculateArea()
        {
            return a*b;
        }
    }

    public class Square : Shape
    { 
        public Square(double a)
        {
            this.a = a;
        }

        public double a { get; set; }

        public override bool IsValid()
        {
            return a > 0 ;
        }
        public override double CalculateArea()
        {
            return a * a;
        }
    }

    class MyCalculater
    {
        public static double Calculate(Shape area)
        {
           
            return area.CalculateArea();
        }
    }

    public static class ShapeFactory
    {
        private static readonly Random random = new Random();

        public static Shape CreateShape() {
            int type=random.Next(0,3);
            switch (type)
            {
                case 0:
                    return new Rectangle(
                        random.NextDouble() * 10,
                        random.NextDouble() * 10);
                    
                case 1:
                    return new Square(random.NextDouble() * 10);
                case 2:
                    return new Circle(random.Next());
                case 3:
                    double a = random.NextDouble() * 9 + 1;
                    double b = random.NextDouble() * 9 + 1;
                    double c = random.NextDouble() * (a + b - 0.1) + 0.1;

                    return new Triangle(a,b,c);
                default: return null;

            }

        }

    }
}
