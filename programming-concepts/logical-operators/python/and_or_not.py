# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    difficulty = "Hard"
    score = 55
    game_over = False

    if not game_over:
        if difficulty == "Hard" and score > 60:
            print("Wow, you are doing great!")
        elif (difficulty == "Normal" or difficulty == "Easy") and score > 40:
            print("Good stuff, keep it up!")
        else:
            print("Keep going!")

            
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
