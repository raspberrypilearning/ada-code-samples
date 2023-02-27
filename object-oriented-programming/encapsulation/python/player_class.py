# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

class Player:

    def __init__(self, given_name):
        self.__name = given_name
        self.__score = 0

    def get_name(self):
        return self.__name
    
    def get_score(self):
        return self.__score
    
    def set_score(self, new_score):
        self.__score = new_score
    

# This code will run if this file is executed directly
# (i.e. not called by another program)

if __name__ == '__main__':
    # Instantiate a new player object
    game_player = Player("Leona")

    player_name = game_player.get_name()
    print(f"The player's name is: {player_name}")

    player_score = game_player.get_score()
    print(f"The player's score is: {player_score}")

    game_player.set_score(20)
    player_score = game_player.get_score()
    print(f"The player's score is now: {player_score}")
