using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            //This calcualtes the are of rectangle
            Console.Write("Please enter length of rectangle: ");
            decimal lengthSide  = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter width of rectangle: ");
            decimal widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthSide *  widthSide;
            Console.WriteLine("The area of your rectangle is: {0}", area);

        }
    }
}
