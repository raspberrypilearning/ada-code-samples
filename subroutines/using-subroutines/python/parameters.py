# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def calculate_sum(number1, number2):
    answer = number1 + number2
    print(answer)


def main():
    print("Enter a number:")
    user_response = input()
    first_num = int(user_response)  # Convert input value to integer
    
    print("Enter another number:")
    user_response = input()
    second_num = int(user_response)  # Convert input value to integer
    
    calculate_sum(first_num, second_num)  # Calls calculate_sum
    
    
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
