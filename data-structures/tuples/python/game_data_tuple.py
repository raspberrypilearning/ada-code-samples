# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def load_game_data():
    """Demonstrates returning a tuple of multiple data types"""
    
    player_name = "TopGamer99"
    level = 5
    time = 764.312

    # Create and return a tuple containing 3 elements
    return player_name, level, time


def main():
    """Return a tuple and display each of the elements"""
    
    print("### Tuple ###")

    # Use a tuple of 3 elements to store data about a game:
    # player_name, level, time
    game_data = load_game_data()

    # Output the values of the tuple
    print(f"\nPlayer: {game_data[0]}")
    print(f"Level: {game_data[1]}")
    print(f"Time played (seconds): {game_data[2]}")
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
