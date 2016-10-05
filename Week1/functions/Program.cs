using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("How many numbers do you want to input?: ");
            int nSize  = int.Parse(Console.ReadLine());

            int[] nArray = new int[nSize];
            for(int i = 1; i <= nSize; i++)
            {
                Console.WriteLine("Insert number " + i + ":");
                nArray[i-1]  = int.Parse(Console.ReadLine());
            }

            int nMax = Max(nArray, nSize);
            Console.WriteLine("Max: " + nMax);
            int nMin = Min(nArray, nSize);
            Console.WriteLine("Min: " + nMin);
            double nAverage = Avg(nArray, nSize);
            Console.WriteLine("Avg: " + nAverage);
        }

        public static int Max(int[] nNumbers, int nSize)
        {
            int nMax = nNumbers[0];
            for(int i=0;i<nSize;i++)
            {
                if(nNumbers[i] > nMax)
                {
                    nMax = nNumbers[i];
                }
            }
            return nMax;
        }
        public static int Min(int[] nNumbers, int nSize)
        {
            int nMin = nNumbers[0];
            for(int i=0;i<nSize;i++)
            {
                if(nNumbers[i] < nMin)
                {
                    nMin = nNumbers[i];
                }
            }
            return nMin;
        }

        public static double Avg(int[] nNumbers, int nSize)
        {
            int sum = 0;

            for(int i=0;i<nSize;i++)
            {
             sum += nNumbers[i];
            }
            double avg = (double)sum / nSize;
            return avg;
        }
    }
}
