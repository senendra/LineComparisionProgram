using System;
namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            Processing process = new Processing();
            process.setLine(1);
            process.setLine(2);
            process.lineCompare();
        }
    }
}
