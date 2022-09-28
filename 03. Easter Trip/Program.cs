using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            string data = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double priceForNight = 0;
            double priceAllNigths = 0;



            switch (destination)
            {


                case "France":
                    switch (data)
                    {
                        case "21-23":
                            priceForNight = 30;
                            break;
                        case "24-27":
                            priceForNight = 35;
                            break;
                        case "28-31":
                            priceForNight = 40;
                            break;


                        default:
                            break;
                    }
                    break;
                case "Italy":
                    switch (data)
                    {
                        case "21-23":
                            priceForNight = 28;
                            break;
                        case "24-27":
                            priceForNight = 32;
                            break;
                        case "28-31":
                            priceForNight = 39;
                            break;


                        default:
                            break;
                    }
                    break;
                case "Germany":
                    switch (data)
                    {
                        case "21-23":
                            priceForNight = 32;
                            break;
                        case "24-27":
                            priceForNight = 37;
                            break;
                        case "28-31":
                            priceForNight = 43;
                            break;


                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }


            priceAllNigths = priceForNight * numNights;
            Console.WriteLine($"Easter trip to {destination} : {priceAllNigths:f2} leva.");





        }
    }
}
