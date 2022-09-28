using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {

            int kozujnaci = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int kurabii = int.Parse(Console.ReadLine());

            double sum = kozujnaci * 3.2 + eggs * 4.35 + kurabii * 5.4 + eggs * 12 * 0.15;

            Console.WriteLine($"{sum:f2}");






        }
    }
}
