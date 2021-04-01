class Item:

    def __init__(self,Title,Platform,Condition,Price):
        self.Title = Title
        self.Platform = Platform
        self.Condition = Condition
        self.Price = Price
        
    def __repr__(self):
        return "Title: {} Platform: {} Condition: {} Price: {}  ".format(self.Title,
                                                                         self.Platform,
                                                                         self.Condition,
                                                                         self.Price)

class Game:
   
    def __init__(self):
        self.games = list()
        self.gamecart = list()
    def create_gamelist(self):
        self.games.append( Item('Persona 5', 'Console','Brandnew',1499) )
        self.games.append( Item('Uncharted', 'Console','2nd Hand',500) )
        self.games.append( Item('Witcher 3', 'Console','Brandnew',1999) )
        #print(self.games)

    def sellgame(self):
        for games in self.games:
            print("Title: {} Platform: {} Condition: {} Price: {}".format(games.Title,
                                                                            games.Platform,
                                                                            games.Condition,
                                                                            games.Price))
            print("-----------------------------")
        user_input = input("What do you want to buy bro?")
        searchFlag = False
        while user_input != "done":
            for gamess in self.games:
                if user_input == gamess.Title:
                    print(gamess.Price)
                    self.gamecart.append(gamess.Price)
                    user_input = input("The game was added to cart, anything else? (gameName/done)")
                    searchFlag = False
                    #break;
                else:
                    searchFlag = True
            if searchFlag == True:
                print("Search is unsuccessful, It seems like we don't have that bro");
                break;
                    
        total_amount_to_pay = sum(self.gamecart)
        print("The total amount to pay is: {}".format(total_amount_to_pay))
                    

class Gameconsole:

    def __init__(self):
        self.gameconsole = list()
        self.gamecon_cart = list()
    def create_gamecon_list(self):
        self.gameconsole.append( Item(Title = "PS5",Condition = "Brandnew",Price = 27650, Platform = "") )
        self.gameconsole.append( Item(Title = "PS4",Condition = "Brandnew",Price = 8000, Platform = "") )
        self.gameconsole.append( Item(Title = "Nintendo Switch",Condition = "Brandnew",Price = 14999, Platform = "") )
        #print(self.gameconsole)

    def sellgame_c(self):
        for games_c in self.gameconsole:
            print("Title: {} Condition: {} Price: {}".format(games_c.Title,
                                                             games_c.Condition,
                                                             games_c.Price))
            print("-----------------------------")
        user_input = input("What do you want to buy bro?")
        searchFlag = False
        while user_input != "done":
            for game_cc in self.gameconsole:
                if user_input == game_cc.Title:
                    print(game_cc.Price)
                    self.gamecon_cart.append(game_cc.Price)
                    user_input = input("The game was added to cart, anything else? (gameName/done)")
                    searchFlag = False
                    break;
                else:
                    searchFlag = True
            if searchFlag == True:
                print("Search is unsuccessful, It seems like we don't have that bro");
                break;
                    
        total_amount_to_pay = sum(self.gamecon_cart)
        print("The total amount to pay is: {}".format(total_amount_to_pay))

class Transaction:
    def trans(self):
        for loop in range(len(Gameconsole.gamecon_cart)):
            print(Gameconsole.gamecon_cart[len])



class Menu:
    def __init__(self):
       print("Welcome to Lemon Game Shop! Here are the items available:")
       print("1) BrandNew/2ndHand Games")
       print("2) Game Consoles")
       print("Choose what the customer wants to buy")
       print("choice: ")
    
    
if __name__ == '__main__':
    games = Game()
    gameconsole = Gameconsole()
    transaction = Transaction()
    user_choice = "1"
    while user_choice == "1":
       menu = Menu()
       user_choice = input("Input selected option: ")
       if user_choice == "1":
           games.create_gamelist()#ADD GAMES
           games.sellgame()
       elif user_choice == "2":
           gameconsole.create_gamecon_list()
           gameconsole.sellgame_c()
           transaction.trans()

       user_choice = input("Press 1 to Continue, Press 2 to Exit ")     
    
