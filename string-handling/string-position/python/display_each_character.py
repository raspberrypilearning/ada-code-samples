# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def display_each_character():
    """Demonstrates how to output each character from a string"""
    password = "ItIsAsecReT"
    
    for index in range(0,11):
        print(password[index])
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    display_each_character()
