using System;

namespace lớp_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Side 1: ");
            double side1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter Side 2: ");
            double side2 = Double.Parse(Console.ReadLine());
            Console.Write("Enter Side 3: ");
            double side3 = Double.Parse(Console.ReadLine());
            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            Triangle triangle = new Triangle(side1, side2, side3, color);

            Console.WriteLine("Triangle have " + triangle.ToString());

            Console.ReadKey();
        }
    }
}
