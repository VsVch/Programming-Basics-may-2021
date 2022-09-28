using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();


            

            while (winner != "End of battle")
            {

                

               if (winner == "one")
                {
                    second = second - 1;
                    if (first == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {second} eggs left.");
                        break;

                    }

                   
                }
                else if (winner == "two")
                {
                    first = first - 1;
                    if (second == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {first} eggs left.");
                        break;
                    }

                    
                }

                winner = Console.ReadLine();

                

            }


            if (first >0 && second > 0)
            {
                Console.WriteLine($"Player one has {first} eggs left.");
                Console.WriteLine($"Player two has {second} eggs left.");
                
            }











        }
    }
}
