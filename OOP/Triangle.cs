using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInClass
{
    public class Triangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle()
        {
            A = 0;
            B = 0;
            C = 0;
        }
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Read()
        {
            Console.Write("Input a: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Input b: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Input c: ");
            C = int.Parse(Console.ReadLine());
        }
        public void WriteDetails()
        {
            Console.WriteLine($"The length of the triangle: {A} - {B} - {C}.");
        }
        public bool CheckTriangle()
        {
            return A + B > C && A + C > B && B + C > A;
        }
        public int CalculatePerimeter()
        {
            return A + B + C;
        }
        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2d;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        ~Triangle()
        {
            Console.WriteLine("~~~~END~~~~");
        }
    }
}
