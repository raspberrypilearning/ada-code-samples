# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_new_item(a_list, item):
    """Adds an item to a list"""
    a_list.append(item)  # Uses built in method   

 
def main():
    shopping_list = []  # An empty list
    new_item = "milk"
    add_new_item(shopping_list, new_item)
    new_item = "bread"
    add_new_item(shopping_list, new_item)
    new_item = "cake"
    add_new_item(shopping_list, new_item)
    print(shopping_list)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
