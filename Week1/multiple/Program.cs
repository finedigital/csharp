using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Please enter integer: ");
            decimal multiple  = decimal.Parse(Console.ReadLine());
            
            
            for (int i = 1; i<= multiple; i++)
            {
                Console.Write(i + "\t");
                for (int j = 2; j <= multiple; j++)
                {
                    Console.Write(i*j + "\t");
                }
            Console.Write("\n");
            }


        }
    }
}
