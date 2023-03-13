# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

from random import randint

def main():
    random_number = randint(1,100)
    print(random_number)

    
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()