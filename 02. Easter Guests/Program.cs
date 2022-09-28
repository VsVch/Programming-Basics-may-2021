using System;

namespace _02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {

            double numGuests = double.Parse(Console.ReadLine());

            double budjet = double.Parse(Console.ReadLine());
            double numEggs = numGuests * 2;
            double priceEggs = numEggs * 0.45;

            

            double numKozunaci = numGuests / 3;
            numKozunaci = Math.Ceiling(numKozunaci);
            double priceKozunaci = numKozunaci * 4;

            double all = priceEggs + priceKozunaci;
            if (budjet >= all)
            {
                Console.WriteLine($"Lyubo bought {numKozunaci} Easter bread and {numEggs} eggs.");
                Console.WriteLine($"He has {(budjet-all):f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {(all-budjet):f2} lv. more.");
            }





        }
    }
}
