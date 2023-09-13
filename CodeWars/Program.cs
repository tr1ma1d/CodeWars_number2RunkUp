



using System;
using System.Globalization;
using System.Linq;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata(1));
            Console.WriteLine(KataNumber2(1));

        }
        static int Kata(int n) //variable 1
        {
            var numberOfLocation = 0;
         
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    numberOfLocation++;
                }
            }
            return numberOfLocation;
        }
        static int KataNumber2(int n)
        {
            return Enumerable.Range(1, n).Select(c => c).Count(x => n % x == 0);
        }
    }
    
}
