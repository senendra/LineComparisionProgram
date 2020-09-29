using System;
namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            //Getting inputs
            int x1, y1, x2, y2;
            //Geeting inputs for both the points of line 1
            Console.WriteLine("Enter values of x1 and y1 for line 1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of x2 and y2 for line 1 : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Line Length : " +line);
        }
    }
}
