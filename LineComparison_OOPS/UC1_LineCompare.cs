using System;

namespace LineComparison_OOPS
{
    class UC1_LineCompare
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            double length1, length2;
            Console.WriteLine("Enter the two points of Line1");
            Console.WriteLine("Enter Points (x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Points (x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the two points of Line2");
            Console.WriteLine("Enter Points (a1,b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Points (a2,b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());

            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((a2 - a1) * (a2 - a1)));

            Console.WriteLine(length1);
            Console.WriteLine(length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("The length of two lines are Equal");
            }
            else
            {
                Console.WriteLine("The length of lines are not Equal");
            }
        }
    }
}
