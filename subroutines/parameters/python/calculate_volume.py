# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def calculate_volume(height, width, depth):
    """Calculate the volume of a cuboid"""
    volume = height * width * depth
    return(volume)


def main():
    input_height = float(input("Enter height: "))
    input_width = float(input("Enter width: "))
    input_depth = float(input("Enter depth: "))
    volume = calculate_volume(input_height, input_width, input_depth)
    print(volume)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
