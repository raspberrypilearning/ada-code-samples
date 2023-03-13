# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def run_quiz():
    """A very simple quiz"""
    answer = input("What is the capital city of Botswana? ")
    if answer == "Gaborone":
        print("Well done!")
    else:
        print("Sorry! That is the wrong answer")


def main():
    name = input("What is your name? ")
    print(f"Welcome {name}")
    run_quiz() 
    print("End of the quiz")   
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
