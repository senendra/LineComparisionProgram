using System;
using System.Collections.Generic;
using System.Text;
namespace LineComparision
{
    class Processing
    {
        //Variables
        public int x1, y1, x2, y2, lineNumber;
        double length, line1, line2;
        Dictionary<int, double> line = new Dictionary<int, double>();
        public void setLine(int lineNumber)
        {
            Console.WriteLine("Enter values of point x1 and y1  for line "+lineNumber+" :");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of point x2 and y2  for line " + lineNumber + " :");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            length = findLenght();
            line.Add( lineNumber , length);
        }
        public int findLenght()
        {
             return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public void lineCompare()
        {
            line1 = line[1];
            line2 = line[2];
            double diffInLength = line1.CompareTo(line2);
            if (diffInLength == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (diffInLength > 0)
            {
                Console.WriteLine("Line 1 is greater in length than line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is greater in length than line 1");
            }
        }
    }
}
