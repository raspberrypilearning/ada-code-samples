# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    cold = True
    wet = False

    if not(cold and wet):
        print("It's OK to go outside")
    else:
        print("I'm going to stay inside")

        
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()