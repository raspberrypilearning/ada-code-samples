# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def show_password_length():
    """Prompts for a password and displays length"""
    password = input("Please enter a password ")
    print(len(password))


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    show_password_length()
