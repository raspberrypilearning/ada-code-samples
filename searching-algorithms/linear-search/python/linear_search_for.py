# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def linear_search_version_1(items, search_item):
    """A linear search algorithm that iterates through every item in the list"""
       
    # Initialise the variable
    found_index = -1

    # Repeat until the end of the list is reached
    for current in range(len(items)):
        print(f"Checking index {current} with value {items[current]}")
                
        # Compare the item at the current index to the search item
        if items[current] == search_item:
            # If the item has been found, store the current index 
            found_index = current
            print("Item found!")

    # Return the index of the search_item or -1 if not found
    return found_index


def main():
    """Perform a linear search on the test data"""
    test_items = [11,25,10,29,15,13,18]
    
    print("### Linear search version 1 (for loop) ###")
    print(test_items)

    # Search for a value and return the found index
    item_to_find = 15
    print(f"\nThe search item is {item_to_find}\n")
    index = linear_search_version_1(test_items, item_to_find)

    if index == -1:
        print(f"\n{item_to_find} was not found in the list")
    else:
        print(f"\n{item_to_find} was found at index {index}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
