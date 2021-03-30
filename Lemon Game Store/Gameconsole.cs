using System;
using System.Collections.Generic; //for the list
using System.Linq; //for the sum
using System.Text;

namespace Lemon_Game_Store
{
    class Gameconsole : Basedetails
    {
        public static List<Gameconsole> gameConsoleList = new List<Gameconsole>(); // public static in order to become available globally
        public static void createConsolelist()
        {
            gameConsoleList.Add(new Gameconsole
            {
                Title = "PS5",
                Condition = "Brandnew",
                Price = 27650
            });

            gameConsoleList.Add(new Gameconsole
            {
                Title = "PS4",
                Condition = "2nd Hand",
                Price = 8000
            });

            gameConsoleList.Add(new Gameconsole
            {
                Title = "NINTENDO SWITCH",
                Condition = "Brandnew",
                Price = 14999
            });
        }
        public static void sellGameconsole()
        {
            foreach (var game_c in gameConsoleList)
            {
                Console.WriteLine($"Title: {game_c.Title}");
                Console.WriteLine($"Item Condition: {game_c.Condition}");
                Console.WriteLine($"Price: {game_c.Price}");

                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("What game console to buy bro?");
            string upperAnswer = Console.ReadLine();
            string user_Gconsole_choice = upperAnswer.ToUpper();
            bool searchFlag = false;
            List<double> gameconsolecart = new List<double>();

            while (user_Gconsole_choice != "DONE")
            {
                foreach (var game_cc in gameConsoleList)
                {
                    if (game_cc.Title == user_Gconsole_choice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {game_cc.Price}");
                        gameconsolecart.Add(game_cc.Price);
                        Console.WriteLine("The game console was added to cart, anything else? (ConsoleName/done)");
                        string upper = Console.ReadLine();
                        user_Gconsole_choice = upper.ToUpper();
                        searchFlag = false;
                        break;
                    }
                    else
                    {
                        searchFlag = true;
                    }
                }
                if (searchFlag == true)
                {
                    Console.WriteLine("Search is unsuccessful, It seems like we don't have that bro");
                    break;
                }
            }
            var total_amt = gameconsolecart.Sum();
            Console.WriteLine($"The total amount to pay is {total_amt}");
        }

    }

}
