# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    tired = False
    early_start = False

    if not(tired or early_start):
        print("I will go out tonight")
    else:
        print("I'm going to stay at home")

        
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()