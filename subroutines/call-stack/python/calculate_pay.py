# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def calculate_pay(h, r):
    """Performs a basic pay calculation"""
    pay =  h * r
    return pay


def main():
    """A simple pay calculator"""
    hours_input = input("Enter hours worked ")
    rate_input = input("Enter hourly rate ")
    hours = float(hours_input)
    rate = float(rate_input)
    pay = calculate_pay(hours, rate)
    print(f"Your pay is £{pay:.2f}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
