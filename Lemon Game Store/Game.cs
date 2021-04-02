using System;
using System.Collections.Generic; //for the list
using System.Linq; //for the sum

namespace Lemon_Game_Store
{
    class Game : BaseDetails
    {
        public static List<Game> gameList = new List<Game>(); // public static in order to become available globally
        public static List<double> gameCart = new List<double>(); //double is used because thats the type of Price
        private string _platform { get; set; } = "PC";  // removed from Basedetail.cs cheanged it to private
        public override void CreateList()
        {
            gameList.Add(new Game { Title = "PERSONA 5", Condition = "Brandnew", Price = 1499, _platform = "Console" });

            gameList.Add(new Game { Title = "UNCHARTED", Condition = "2nd Hand", Price = 500, _platform = "Console" });

            gameList.Add(new Game { Title = "WITCHER 3", Condition = "Brandnew", Price = 1999, _platform = "PC" });
        }
        public static void SellGame()
        {
            foreach (var games in gameList)
            {
                Console.WriteLine($"Title: {games.Title}");
                Console.WriteLine($"Platform: {games._platform}");
                Console.WriteLine($"Item Condition: {games.Condition}");
                Console.WriteLine($"Price: {games.Price}");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("What game to buy?");
            string upperAnswer = Console.ReadLine();
            string userGameChoice = upperAnswer.ToUpper();
            bool searchFlag = false;

            while (userGameChoice != "0")
            {
                foreach (var games_ in gameList)
                {
                    if (games_.Title == userGameChoice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {games_.Price}");
                        gameCart.Add(games_.Price);
                        Console.WriteLine("The game was added to cart, anything else? (Enter 0 to proceed to payment)");
                        string upper = Console.ReadLine();
                        userGameChoice = upper.ToUpper();
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
                    Console.WriteLine("Search is unsuccessful, it seems like we don't have that");
                    Console.WriteLine("Search another game (Enter 0 to exit)");
                    string upper = Console.ReadLine();
                    userGameChoice = upper.ToUpper();
                }
            }
            var totalAmount = gameCart.Sum();
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
                    int userMoney_ = Convert.ToInt32(Console.ReadLine());
                    while (userMoney_ < totalAmount)
                    {
                        Console.WriteLine("Not enough funds!");
                        Console.WriteLine("Input the amount you have: ");
                        userMoney_ = Convert.ToInt32(Console.ReadLine());
                    }
                    var exchange_ = userMoney_ - totalAmount;
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
