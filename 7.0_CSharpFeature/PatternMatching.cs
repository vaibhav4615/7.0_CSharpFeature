using System;

namespace _7._0_CSharpFeature
{
    public class Figure
    {
        public double pi = 3.14;
    }

    public class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
    }

    public class PatternMatching
    {
        void PrintData(Figure f)
        {
            switch (f)
            {
                case Rectangle rec when rec.Height == rec.Width:
                    Console.WriteLine("Rectangle = " + rec.Height * rec.Width);
                    break;
                case Rectangle rec:
                    Console.WriteLine("Rectangle = "+ rec.Height * rec.Width);
                    break;
                case Circle cir:
                    Console.WriteLine("Circle = " + cir.Radius * cir.pi);
                    break;
            }
        }
        static void Main()
        {
            Rectangle rec = new() { Height = 12.00, Width = 23.025 };
            Rectangle rec1 = new() { Height = 12.00, Width = 12.00 };
            Circle cir = new() { Radius = 12.6 };
            PatternMatching p = new();
            p.PrintData(rec);
            p.PrintData(rec1);
            p.PrintData(cir);

            Console.ReadLine();
        }
    }
}
