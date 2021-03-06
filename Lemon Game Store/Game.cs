﻿using System;
using System.Collections.Generic;
using System.Linq;
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
                    Console.WriteLine("Search is unsuccessful, It seems like we don't have that bro");
            }
             var total_amt = gamecart.Sum();
             Console.WriteLine($"The total amount to pay is {total_amt}");

        }
    }
}
