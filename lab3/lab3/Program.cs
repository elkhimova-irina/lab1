
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using lab3;

namespace лаба2
{
    interface IPrint
    {
        void Print();
    }

    abstract class GeomFigura : IComparable
    {
        public string Figura { get; protected set; }

        public abstract double Area();
        public override string ToString()
        {
            return this.Figura + " площадью " + this.Area().ToString();
        }
        public int CompareTo(object f2)
        {
            GeomFigura f1 = (GeomFigura)f2;
              if (this.Area() < f1.Area()) 
                return -1;
            else
              if (this.Area() == f1.Area()) 
                return 0;
            else 
                return 1;
        }
    }


    class Rect : GeomFigura, IPrint
    {
        double height;
        double width;
        public Rect(double height, double width)
        {
            this.height = height;
            this.width = width;
            this.Figura = "Прямоугольник";
        }
        public override double Area()
        {
            return this.width * this.height;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Circle : GeomFigura, IPrint
    {
        double radius;
        public Circle(double pr)
        {
            this.radius = pr;
            this.Figura = "Круг";
        }

        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }


    class Square : Rect, IPrint
    {
        public Square(double size)
            : base(size, size)
        {
            this.Figura = "Квадрат";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Elkhimova-irina ICS5-33B");
            Rect rect = new Rect(5, 4);
            Square square = new Square(10);
            Circle circle = new Circle(3);
           // circle.Print();

            Console.WriteLine("\nArrayList");
            ArrayList ar = new ArrayList();
            ar.Add(circle);
            ar.Add(rect);
            ar.Add(square);

            foreach (var x in ar) Console.WriteLine(x);

            Console.WriteLine("\nArrayList - сортировка");
            ar.Sort();
            foreach (var x in ar) Console.WriteLine(x);

            Console.WriteLine("\nList<GeomFigura>");
            List<GeomFigura> figuraList = new List<GeomFigura>();
            figuraList.Add(circle);
            figuraList.Add(rect);
            figuraList.Add(square);

            foreach (var x in figuraList) Console.WriteLine(x);

            Console.WriteLine("\nList<AbstractFigure> - сортировка");
            ar.Sort();

            foreach (var x in ar) Console.WriteLine(x);
     

                   Console.WriteLine("\nMatrix<GeomFigure>");
                   Matrix<GeomFigura> matrix = new Matrix<GeomFigura>(2, 2, 2, square);
                   Console.WriteLine(matrix.ToString());

                   Console.WriteLine("SimpleList<GeomFigura>");
                   SimpleList<GeomFigura> list = new SimpleList<GeomFigura>();
                   list.Add(square);
                   list.Add(rect);
                   list.Add(circle);

                   foreach (var x in list) Console.WriteLine(x);

                   Console.WriteLine("\nSimpleList<GeomFigura> - отсортированный");
                   list.Sort();

                   foreach (var x in list) Console.WriteLine(x);


                   Console.WriteLine("\nSimpleStack<GeomFigure>");
                   SimpleStack<GeomFigura> stack = new SimpleStack<GeomFigura>();
                   stack.Push(rect);
                   stack.Push(square);
                   stack.Push(circle);

                   while (stack.Count > 0)
                   {
                       GeomFigura f = stack.Pop();
                       Console.WriteLine(f);
                   }
                   Console.ReadKey();
        } 
    }
}
    


