using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {


            int numGuests = int.Parse(Console.ReadLine());
            double priceForOnePerson = double.Parse(Console.ReadLine());
            double budjjet = double.Parse(Console.ReadLine());
            double priceForCake = budjjet * 0.1;

            double discoun = 0;
            if (numGuests >= 10 && numGuests <= 15)
            {
                discoun = 0.15;
            }
            else if (numGuests > 15 && numGuests <= 20)
            {
                discoun = 0.2;
            }
            else if (numGuests > 20)
            {
                discoun = 0.25;
            }
            else
            {
                discoun = 0;
            }
            
            double priceForAll = numGuests * (priceForOnePerson - priceForOnePerson * discoun);
            priceForAll = priceForAll + priceForCake;

            if (budjjet >= priceForAll)
            {
                Console.WriteLine($"It is party time! {(budjjet-priceForAll):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {(priceForAll-budjjet):f2} leva needed.");
            }
            

        }
    }
}
