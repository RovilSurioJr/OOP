from OOP_FINALS import Item as I
class Game:
    def __init__(self):
        self.sell_product = []
        self.buy_product = []
        self.sell_cart = []
        self.buy_cart = []
    def createlist_sellproduct(self):
        self.sell_product.append(I.Item(Title='Persona 5', Platform='Console', Condition='Brandnew', Price=1499))
        self.sell_product.append(I.Item(Title='Uncharted', Platform='Console', Condition='Brandnew', Price=500))
        self.sell_product.append(I.Item(Title='Witcher 3', Platform='Console', Condition='Brandnew', Price=1999))
    def sellproduct(self):
        for product in self.sell_product:
            print("Title: {}\nPlatform: {}\nCondition: {}\nPrice: {}".format(product.Title,
                                                                             product.Platform,
                                                                             product.Condition,
                                                                             product.Price))
            print("-----------------------------")
        user_input = input("Choose what to sell:")
        searchFlag = False
        while user_input != "0":
            for products in self.sell_product:
                if user_input.lower() == products.Title.lower():
                    print(products.Price)
                    self.sell_cart.append(products.Price)
                    user_input = input("The game was added to cart, anything else? (Enter 0 to proceed to payment)")
                    searchFlag = False
                    break
                else:
                    searchFlag = True
            if searchFlag == True:
                print("Search is unsuccessful, It seems like we don't have that");
                user_input = input("Search another game (Enter 0 to proceed to payment): ")
        total_amount_to_pay = sum(self.sell_cart)
        customer_pay = int(input("Input the customer's money: "))
        if customer_pay >= total_amount_to_pay:
            change = customer_pay - total_amount_to_pay
            print("Transaction Successful")
            print("Change: ", change)
        elif customer_pay < total_amount_to_pay:
            print("Insufficient Money")


    def createlist_buyproduct(self):
        self.buy_product.append(I.Item(Title='Sekiro', Platform='PC', Condition='2nd Hand', Price=1899))
        self.buy_product.append(I.Item(Title='Doom Eternal', Platform='PC', Condition='2nd Hand', Price=1380))
        self.buy_product.append(I.Item(Title='Bayonetta', Platform='Console', Condition='2nd Hand', Price=250))

    def buyproduct(self):
        for product in self.buy_product:
            print("Title: {}\nPlatform: {}\nCondition: {}\nPrice: {}".format(product.Title,
                                                                             product.Platform,
                                                                             product.Condition,
                                                                             product.Price))
            print("-----------------------------")
        user_input = input("Choose what to buy:")
        searchFlag = False
        while user_input != "0":
            for products in self.buy_product:
                if user_input.lower() == products.Title.lower():
                    print(products.Price)
                    self.buy_cart.append(products.Price)
                    self.sell_product.append(products)
                    user_input = input("The game was added to cart, anything else? (Enter 0 to proceed to payment)")
                    searchFlag = False
                    break
                else:
                    searchFlag = True
            if searchFlag == True:
                print("Search is unsuccessful, It seems like we don't want to buy that");
                user_input = input("Search another game (Enter 0 to proceed to payment): ")

        total_amount_to_pay = sum(self.buy_cart)
        cashier_pay = int(input("Input the cashier's money: "))
        if cashier_pay >= total_amount_to_pay:
            change = cashier_pay - total_amount_to_pay
            print("Transaction Successful")
            print("Change: ", change)
        elif cashier_pay < total_amount_to_pay:
            print("Insufficient Money")


class Gameconsole(Game): # inherited the Game class

    def createlist_sellproduct(self):
        self.sell_product.append(I.Item(Title="PS5", Condition="Brandnew", Price=27650, Platform=""))
        self.sell_product.append(I.Item(Title="PS4", Condition="Brandnew", Price=8000, Platform=""))
        self.sell_product.append(I.Item(Title="Nintendo Switch", Condition="Brandnew", Price=14999, Platform=""))

    def createlist_buyproduct(self):
        self.buy_product.append(I.Item(Title="PS3", Condition="2nd Hand", Price=8500, Platform=""))
        self.buy_product.append(I.Item(Title="PS2", Condition="2nd Hand", Price=3000, Platform=""))
        self.buy_product.append(I.Item(Title="Xbox 360", Condition="2nd Hand", Price=5000, Platform=""))

