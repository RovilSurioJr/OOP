using System;
using System.Collections.Generic; //for the list
using System.Linq; //for the sum

namespace Lemon_Game_Store
{
    class GameConsole : BaseDetails
    {
        public static List<GameConsole> gameConsoleList = new List<GameConsole>(); // public static in order to become available globally
        public static List<double> gameConsoleCart = new List<double>();
        public override void CreateList()
        {
            gameConsoleList.Add(new GameConsole{Title = "PS5",Condition = "Brandnew",Price = 27650});
            gameConsoleList.Add(new GameConsole{Title = "PS4",Condition = "2nd Hand",Price = 8000});
            gameConsoleList.Add(new GameConsole{Title = "NINTENDO SWITCH",Condition = "Brandnew",Price = 14999});
        }
        public static void SellGameConsole()
        {
            foreach (var gameConsole in gameConsoleList)
            {
                Console.WriteLine($"Title: {gameConsole.Title}");
                Console.WriteLine($"Item Condition: {gameConsole.Condition}");
                Console.WriteLine($"Price: {gameConsole.Price}");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("What game console to buy?");
            string upperAnswer = Console.ReadLine();
            string userGaconsoleChoice = upperAnswer.ToUpper();
            bool searchFlag = false;

            while (userGaconsoleChoice != "0")
            {
                foreach (var game_Console in gameConsoleList)
                {
                    if (game_Console.Title == userGaconsoleChoice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {game_Console.Price}");
                        gameConsoleCart.Add(game_Console.Price);
                        Console.WriteLine("The game console was added to cart, anything else? (Enter 0 to proceed to payment)");
                        string upper = Console.ReadLine();
                        userGaconsoleChoice = upper.ToUpper();
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
                    Console.WriteLine("Search another game console (Enter 0 to exit)");
                    string upper = Console.ReadLine();
                    userGaconsoleChoice = upper.ToUpper();
                }
            }
            var totalAmount = gameConsoleCart.Sum();
            Console.WriteLine($"The total amount to pay is {totalAmount}");
            Console.WriteLine("Input the amount you have: ");
            int userMoney = Convert.ToInt32(Console.ReadLine());
            var exchange = userMoney - totalAmount;
            if (totalAmount > userMoney)
            {
                Console.WriteLine("Not enough funds!");
                Console.WriteLine("Try again?(Y/N)");
                string upper = Console.ReadLine();
                string userAns = upper.ToUpper();
                if (userAns == "Y")
                {
                    Console.WriteLine("Input the amount you have: ");
                    int user_Money = Convert.ToInt32(Console.ReadLine());
                    while (user_Money < totalAmount)
                    {
                        Console.WriteLine("Not enough funds!");
                        Console.WriteLine("Input the amount you have: ");
                        user_Money = Convert.ToInt32(Console.ReadLine());
                    }
                    var exchange_ = user_Money - totalAmount;
                    Console.WriteLine($"Thank you! Your exchange is {exchange_}");
                }
            }
            else
            {
                Console.WriteLine($"Thank you! Your exchange is {exchange}");
            }
        }

    }

}
