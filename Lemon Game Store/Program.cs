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

    }
}
