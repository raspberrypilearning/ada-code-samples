# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_two_numbers(number1, number2):
    answer = number1 + number2
    return answer


def main():
    result = add_two_numbers(5, 10)
    print(result)
    
    
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
