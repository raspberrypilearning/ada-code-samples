# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4


def global_example():
    """This function accesses a global variable"""
    print(number)


number = 5  # global variable
global_example()
print(number)
