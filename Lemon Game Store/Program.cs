using System;
using System.Collections.Generic;

namespace Lemon_Game_Store
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
    }
}
