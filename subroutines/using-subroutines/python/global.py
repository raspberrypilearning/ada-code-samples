# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def global_example():
    """This function accesses a global variable"""
    print(number)


number = 5  # global variable
global_example()
print(number)
