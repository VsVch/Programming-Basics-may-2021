using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string colourEggs = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double price = 0;
            double profit = 0;

            switch (sizeEggs)
            {

                case "Large":
                    switch (colourEggs)
                    {

                        case "Red":
                            price = 16;
                            break;
                        case "Green":
                            price = 12;
                            break;
                        case "Yellow":
                            price = 9;
                            break;


                        default:
                            break;
                    }
                    break;
                case "Medium":
                    switch (colourEggs)
                    {

                        case "Red":
                            price = 13;
                            break;
                        case "Green":
                            price = 9;
                            break;
                        case "Yellow":
                            price = 7;
                            break;


                        default:
                            break;
                    }
                    break;
                case "Small":
                    switch (colourEggs)
                    {

                        case "Red":
                            price = 9;
                            break;
                        case "Green":
                            price = 8;
                            break;
                        case "Yellow":
                            price = 5;
                            break;


                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }


            profit = num * price;
            profit = profit - profit * 0.35;
            Console.WriteLine($"{profit:f2} leva.");



        }
    }
}
