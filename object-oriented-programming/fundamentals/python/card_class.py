# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

class PlayingCard:

    def __init__(self, given_suit, given_rank, given_value):
        self.__suit = given_suit
        self.__rank = given_rank
        self.__value = given_value
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":    
    # Instantiate an example Card object
    my_card = PlayingCard("clubs", "2", 2)
    
    # Show that the card object has been created
    print(my_card);
