# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4


def calculate_sum(number1, number2):
    answer = number1 + number2
    return answer


def main():
    print("Enter a number:")
    user_response = input()
    number1 = int(user_response)  # Convert input value to integer
    print("Enter another number:")
    user_response = input()
    number2 = int(user_response)  # Convert input value to integer
    calculate_sum(number1, number2)  # Calls calculate_sum
    
    
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
