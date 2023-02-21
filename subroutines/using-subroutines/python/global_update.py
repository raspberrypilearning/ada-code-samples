# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def global_update_example():
    global number
    number = 10
    print(number)


number = 5
global_update_example()
print(number)
