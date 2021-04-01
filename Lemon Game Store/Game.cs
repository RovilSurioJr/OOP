using System;
using System.Collections.Generic; //for the list
using System.Linq; //for the sum
using System.Text;

namespace Lemon_Game_Store
{
    class Game : Basedetails
    {
        public static List<Game> Gamelist = new List<Game>(); // public static in order to become available globally
        public static void createGamelist()
        {
            //List<Game> theGames = new List<Game>();
            Gamelist.Add(new Game
            {
                Title = "PERSONA 5",
                Platform = "Console",
                Condition = "Brandnew",
                Price = 1499
            });

            Gamelist.Add(new Game
            {
                Title = "UNCHARTED",
                Platform = "Console",
                Condition = "2nd Hand",
                Price = 500
            });

            Gamelist.Add(new Game
            {
                Title = "WITCHER 3",
                Platform = "PC",
                Condition = "Brandnew",
                Price = 1999
            });
        }
        public static void sellGame()
        {
            foreach (var games in Gamelist)
            {
                Console.WriteLine($"Title: {games.Title}");
                Console.WriteLine($"Platform: {games.Platform}");
                Console.WriteLine($"Item Condition: {games.Condition}");
                Console.WriteLine($"Price: {games.Price}");

                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("What game to buy bro?");
            string upperAnswer = Console.ReadLine();
            string user_Game_choice = upperAnswer.ToUpper();
            bool searchFlag = false;
            List<double> gamecart = new List<double>(); //double is used because thats the type of Price

            while (user_Game_choice != "DONE")
            {
                foreach (var gamess in Gamelist)
                {
                    if (gamess.Title == user_Game_choice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {gamess.Price}");
                        gamecart.Add(gamess.Price);
                        Console.WriteLine("The game was added to cart, anything else? (GameName/Done)");
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
                    Console.WriteLine("Search is unsuccessful, It seems like we don't have that bro");
                    break;
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
