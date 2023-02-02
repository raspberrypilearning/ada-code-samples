# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4


def calculate_area(length):
    """Calculates the area of a square of a given side length"""
    area = length * length
    return area


def main():
    length = 12
    result = calculate_area(length)
    print(result)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main() 
