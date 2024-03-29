# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def binary_search_recursive(items, search_item, first, last):
    """A recursive binary search algorithm"""

    # Base case for recursion: The recursion will stop when the
    # index of the first item is greater than the index of last
    if first > last:
        return -1 # Return -1 if the search item is not found

    # Recursively call the function
    else:
        # Find the midpoint position (in the middle of the range)
        midpoint = (first + last) // 2
        print(f"Checking from index {first} to {last} with midpoint {midpoint}")
        
        # Compare the item at the midpoint to the search item
        if items[midpoint] == search_item:
            # If the item has been found, return the midpoint position
            print("Item found! Stopping the search")
            return midpoint
     
        # Check if the item at the midpoint is less than the search item 
        elif items[midpoint] < search_item:
            # Focus on the items after the midpoint
            first = midpoint + 1
            return binary_search_recursive(items, search_item, first, last)

        # Otherwise the item at the midpoint is greater than the search item
        else:
            # Focus on the items before the midpoint
            last = midpoint - 1 
            return binary_search_recursive(items, search_item, first, last)


def main():
    """Perform a binary search on the test data"""
    test_items = [10,11,13,15,18,25,29]

    first_index = 0
    last_index = len(test_items) - 1
    
    print("### Binary search (recursive) ###")
    print(test_items)

    # Search for a value and return the found index
    item_to_find = 18
    print(f"\nThe search item is {item_to_find}\n")
    index = binary_search_recursive(test_items, item_to_find, first_index, last_index)

    if index == -1:
        print(f"\n{item_to_find} was not found in the list")
    else:
        print(f"\n{item_to_find} was found at index {index}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
