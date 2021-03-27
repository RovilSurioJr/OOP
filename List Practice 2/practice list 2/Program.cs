using System;
using System.Collections.Generic;
using System.Linq; //for the sum

namespace LemonStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
            ShowAllItems();
        }

        static void Menu()
        {
            Console.WriteLine("Welcome to Lemon Game Shop! Here are the items available: ");
            Console.WriteLine("1) BrandNew/2ndHand Games");
            Console.WriteLine("2) Game Consoles");
            Console.WriteLine("Choose what the customer wants to buy");
            Console.Write("choice: ");
        }

        static void ShowAllItems()
        {
            var user_choice = Console.ReadLine();

            switch (user_choice)
            {
                case "1":
                    Game.createGamelist();
                    Game.sellGame();
                    break;
                case "2":
                    Gameconsole.createConsolelist();
                    Gameconsole.sellGameconsole();
                    break;
                default:
                    Console.WriteLine("Please select a number that is in the menu!");
                    ShowAllItems();
                    break;
            }
            // To keep the console open while debugging
            Console.WriteLine("Press any key to exit bro.");
            Console.ReadKey();
        }

        class Basedetails
        {
            // For game details and console
            //  This is class is for inheritance, so that we will not create these get and set for every class
            public string Title { get; set; }
            public string Platform { get; set; }
            public string Condition { get; set; }
            public double Price { get; set; }

        }

        class Game : Basedetails
        {
            public static List<Game> Gamelist = new List<Game>(); // public static in order to become available globally
            public static void createGamelist()
            {
                //List<Game> theGames = new List<Game>();
                Gamelist.Add(new Game
                {
                    Title = "Persona 5",
                    Platform = "Console",
                    Condition = "Brandnew",
                    Price = 1499
                });

                Gamelist.Add(new Game
                {
                    Title = "Uncharted",
                    Platform = "Console",
                    Condition = "2nd Hand",
                    Price = 500
                });

                Gamelist.Add(new Game
                {
                    Title = "Witcher 3",
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
                var user_answer = Console.ReadLine();
                bool searchFlag = false;
                List<double> gamecart = new List<double>(); //double is used because thats the type of Price

                while (user_answer != "done")
                {
                    foreach (var gamess in Gamelist)
                    {
                        if (gamess.Title == user_answer)
                        {
                            Console.WriteLine("Search is successful");
                            Console.WriteLine($"The price is {gamess.Price}");
                            gamecart.Add(gamess.Price);
                            Console.WriteLine("The game was added to cart, anything else? (gameName/done)");
                            user_answer = Console.ReadLine();
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
            }
        }
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
                        Title = "Nintendo Switch",
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
                var user_gconsole_choice = Console.ReadLine();
                bool searchFlag = false;
                List<double> gameconsolecart = new List<double>();

                while (user_gconsole_choice != "done")
                {
                    foreach (var game_cc in gameConsoleList)
                    {
                        if (game_cc.Title == user_gconsole_choice)
                        {
                            Console.WriteLine("Search is successful");
                            Console.WriteLine($"The price is {game_cc.Price}");
                            gameconsolecart.Add(game_cc.Price);
                            Console.WriteLine("The game console was added to cart, anything else? (ConsoleName/done)");
                            user_gconsole_choice = Console.ReadLine();
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
}
