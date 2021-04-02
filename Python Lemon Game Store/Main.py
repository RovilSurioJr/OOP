from OOP_FINALS import Game as G
from OOP_FINALS import Menu as M

if __name__ == '__main__':
    games = G.Game()
    gameconsole = G.Gameconsole()
    user_choice = "1"
    while user_choice == "1":
        menu = M.Menu()
        user_choice = input("Input selected option: ")
        if user_choice == "1":
            games.createlist_sellproduct()
            games.sellproduct()
        elif user_choice == "2":
            gameconsole.createlist_sellproduct()
            gameconsole.sellproduct()
        elif user_choice == "3":
            games.createlist_buyproduct()
            games.buyproduct()
        elif user_choice == "4":
            gameconsole.createlist_buyproduct()
            gameconsole.buyproduct()
        user_choice = input("Press 1 to Continue, Press 2 to Exit ")

