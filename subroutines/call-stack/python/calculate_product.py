# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def calculate_product(n1, n2):
    """Calculates the product of two numbers"""
    product = n1 * n2
    print(product)


def main():
    """Simple program to demonstrate use of call stack"""
    num1_input = input("Enter a number ")
    num2_input = input("Enter another number ")
    num1 = int(num1_input)
    num2 = int(num2_input)
    calculate_product(num1, num2)
    print("I hope you enjoyed using the product calculator")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
