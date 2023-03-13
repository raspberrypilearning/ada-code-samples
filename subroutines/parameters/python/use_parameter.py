# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def welcome_user(user):
    """Greets the user by name"""
    print("Greetings " + user)


def main():
    username = input("What is your name?")
    welcome_user(username)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
