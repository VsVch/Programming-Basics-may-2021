using System;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {

            double breath = double.Parse(Console.ReadLine());
            double kiloBreathj = double.Parse(Console.ReadLine());
            double kiloSujgar = double.Parse(Console.ReadLine());
            int countEgss = int.Parse(Console.ReadLine());
            int packetMay = int.Parse(Console.ReadLine());

            double priceSujgar = breath - 0.25 * breath;
            double priceEgss = breath + 0.1 * breath;
            double priceMay = priceSujgar - 0.8 * priceSujgar;

            double all = breath * kiloBreathj + kiloSujgar * priceSujgar + countEgss * priceEgss + packetMay * priceMay;

            Console.WriteLine($"{all:f2}");
            

        }
    }
}
