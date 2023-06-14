using System;

namespace DemoProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("The area is:");
            Console.WriteLine(GetRegtangleArea(a, b));
        }

        public static double GetRegtangleArea(double a, double b)
        {
            return a * b;
        }
    }
}
