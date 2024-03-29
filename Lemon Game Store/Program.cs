﻿using System;

namespace Lemon_Game_Store

/*At the outermost level of a program, types are organized into namespaces. The
 using directive was used to make the System namespace available to our application,
 to use the Console class We defined all our classes within Lemon_Game_Store namespace*/
{
    class Program
    {
        public static void Main(string[] args) // Void because it doesn't return any value to the caller
                                               // signaling the default entry point of execution.
        {
            Menu();
            ShowAllItems();
        }

        static void Menu()
        {
            Console.WriteLine("Welcome to Lemon Game Shop! Here are the items available: ");
            Console.WriteLine("1) Sell BrandNew/2ndHand Games");
            Console.WriteLine("2) Sell Game Consoles");
            Console.WriteLine("3) Buy Game/Game Console ");
            Console.WriteLine("Choose what to do");
            Console.WriteLine("choice: ");
        }

        static void BuyItems()
        {
            var user_choice = Console.ReadLine();

            switch (user_choice)
            {
                case "1":
                    Console.WriteLine("Input Game Title");
                    Console.WriteLine("Input Condition");
                    Console.WriteLine("Input Price");
                    string upper = Console.ReadLine();
                    Game.gameList.Add(new Game
                    {
                        Title = upper.ToUpper(),
                        Condition = Console.ReadLine(),
                        Price = Convert.ToInt32(Console.ReadLine())
                    });
                    Menu();
                    ShowAllItems();
                    break;
                case "2":
                    Console.WriteLine("Input Console Name");
                    Console.WriteLine("Input Condition");
                    Console.WriteLine("Input Price");
                    string bupper = Console.ReadLine();
                    GameConsole.gameConsoleList.Add(new GameConsole
                    {
                        Title = bupper.ToUpper(),
                        Condition = Console.ReadLine(),
                        Price = Convert.ToInt32(Console.ReadLine())
                    });
                    Menu();
                    ShowAllItems();
                    break;
                default:
                    Console.WriteLine("Please select a number that is in the menu!");
                    ShowAllItems();
                    break;
            }
        }

        static void ShowAllItems()
        {
            var user_choice = Console.ReadLine();

            switch (user_choice)
            {
                case "1":
                    Game cl = new Game();
                    cl.CreateList();
                    Game.SellGame();
                    break;
                case "2":
                    GameConsole gc = new GameConsole();
                    gc.CreateList();
                    GameConsole.SellGameConsole();
                    break;
                case "3":
                    Console.WriteLine("Choose to Buy:");
                    Console.WriteLine("1) Game");
                    Console.WriteLine("2) Game Console");
                    BuyItems();
                    break;
                default:
                    Console.WriteLine("Please select a number that is in the menu!");
                    ShowAllItems();
                    break;
            }
            // To keep the console open while debugging
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
