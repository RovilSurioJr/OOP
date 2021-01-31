using System;
using System.Collections.Generic;

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
            Console.WriteLine("1. Brand New Games");
            Console.WriteLine("2. 2nd hand games");
            Console.WriteLine("3. Consoles");
            Console.WriteLine("Pleaase choose what you want bro!!");

        }

        static void ShowAllItems()
        {
            var user_choice = Console.ReadLine();

            switch (user_choice)
            {
                case "1":
                    Game.createGame();
                    Game.sellGame();
                    break;
            }
        }

        class Game
        {

            public string Title { get; set; }
            public string Platform { get; set; }
            public double Price { get; set; }

            public static List<Game> theGames = new List<Game>(); // public static in order to become available globally



            public static void createGame()
            {
                //List<Game> theGames = new List<Game>();
                theGames.Add(new Game
                {
                    Title = "Persona 5",
                    Platform = "Console",
                    Price = 1499
                });

                theGames.Add(new Game
                {
                    Title = "Uncharted",
                    Platform = "Console",
                    Price = 1099
                });

                theGames.Add(new Game
                {
                    Title = "Witcher 3",
                    Platform = "PC",
                    Price = 1999
                });
            }
            public static void sellGame()
            {
                foreach (var games in theGames)
                {
                    Console.WriteLine(games.Title);
                    Console.WriteLine(games.Platform);
                    Console.WriteLine(games.Price);
                    Console.WriteLine("-----------------------------");
                }


                Console.WriteLine("What game to buy bro?");
                var user_game_choice = Console.ReadLine();
                bool searchFlag = false;
                foreach (var gamess in theGames)
                {
                    if (gamess.Title == user_game_choice)
                    {
                        Console.WriteLine("Search is successful");
                        Console.WriteLine($"The price is {gamess.Price}");


                        searchFlag = false;
                        break;
                    }
                    else
                    {

                        searchFlag = true;

                    }
                }
                if (searchFlag == true)
                    Console.WriteLine("Search is unsuccessful, It seems like we don't have that bro");




            }

        }



    }
}
