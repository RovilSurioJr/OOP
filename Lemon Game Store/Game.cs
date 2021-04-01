using System;
using System.Collections.Generic; //for the list
using System.Linq; //for the sum
using System.Text;

namespace Lemon_Game_Store
{
    class Game : Basedetails
    {
        public static List<Game> Gamelist = new List<Game>(); // public static in order to become available globally
        public static List<double> gamecart = new List<double>(); //double is used because thats the type of Price
        private string platform { get;  set; }   // removed from Basedetail.cs cheanged it to private
        public override void createlist()
        {
            Gamelist.Add(new Game { title = "PERSONA 5", condition = "Brandnew", price = 1499, platform = "Console" });

            Gamelist.Add(new Game { title = "UNCHARTED", condition = "2nd Hand", price = 500, platform = "Console" });

            Gamelist.Add(new Game { title = "WITCHER 3", condition = "Brandnew", price = 1999, platform = "PC" });
        }
        public static void sellGame()
        {
            foreach (var games in Gamelist)
            {
                Console.WriteLine($"Title: {games.title}");
                Console.WriteLine($"Platform: {games.platform}");
                Console.WriteLine($"Item Condition: {games.condition}");
                Console.WriteLine($"Price: {games.price}");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("What game to buy?");
            string upperAnswer = Console.ReadLine();
            string user_Game_choice = upperAnswer.ToUpper();
            bool searchFlag = false;

            while (user_Game_choice != "0")
            {
                foreach (var gamess in Gamelist)
                {
                    if (gamess.title == user_Game_choice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {gamess.price}");
                        gamecart.Add(gamess.price);
                        Console.WriteLine("The game was added to cart, anything else? (Enter 0 to proceed to payment)");
                        string upper = Console.ReadLine();
                        user_Game_choice = upper.ToUpper();
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
                    user_Game_choice = upper.ToUpper();
                }
            }
            var total_amt = gamecart.Sum();
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
