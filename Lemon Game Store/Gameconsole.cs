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
                title = "PS5",
                condition = "Brandnew",
                price = 27650
            });

            gameConsoleList.Add(new Gameconsole
            {
                title = "PS4",
                condition = "2nd Hand",
                price = 8000
            });

            gameConsoleList.Add(new Gameconsole
            {
                title = "NINTENDO SWITCH",
                condition = "Brandnew",
                price = 14999
            });
        }
        public static void sellGameconsole()
        {
            foreach (var game_c in gameConsoleList)
            {
                Console.WriteLine($"Title: {game_c.title}");
                Console.WriteLine($"Item Condition: {game_c.condition}");
                Console.WriteLine($"Price: {game_c.price}");

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
                    if (game_cc.title == user_Gconsole_choice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {game_cc.price}");
                        gameconsolecart.Add(game_cc.price);
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
            Console.WriteLine($"The total amount to pay is {total_amt}");
            Console.WriteLine("Input the amount you have: ");
            int user_money = Convert.ToInt32(Console.ReadLine());
            var exchange = user_money - total_amt;
            if (total_amt > user_money)
            {
                Console.WriteLine("Not enough funds!");
                Console.WriteLine("Try again?(Y/N)");
                string upper = Console.ReadLine();
                string user_ans = upper.ToUpper();
                if (user_ans == "Y")
                {
                    Console.WriteLine("Input the amount you have: ");
                    int user_moneyy = Convert.ToInt32(Console.ReadLine());
                    while (user_moneyy < total_amt)
                    {
                        Console.WriteLine("Not enough funds!");
                        Console.WriteLine("Input the amount you have: ");
                        user_moneyy = Convert.ToInt32(Console.ReadLine());
                    }
                    var exchangee = user_moneyy - total_amt;
                    Console.WriteLine($"Thank you! Your exchange is {exchangee}");
                }

            }
            else
            {
                Console.WriteLine($"Thank you! Your exchange is {exchange}");
            }
        }

    }

}
