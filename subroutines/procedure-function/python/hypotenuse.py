# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

import math


def calculate_area(length):
    """Calculates the area of a square of a given side length"""
    area = length * length
    return area


def get_hypotenuse(a, b):
    """Calculates the length of the hypotenuse of a right angled triangle"""
    h = math.sqrt( calculate_area(a) + calculate_area(b) ) 
    return h


def main():
    side1 = 3
    side2 = 4
    hypotenuse = get_hypotenuse(side1, side2)
    print(hypotenuse)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main() 
