# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


class Node:
    """A node in a binary search tree"""
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

    def get_data(self):
        return self.data

    def get_left(self):
        return self.left

    def set_left(self, new_left):
        self.left = new_left

    def get_right(self):
        return self.right

    def set_right(self, new_right):
        self.right = new_right


class BST:
    """A class for constructing a binary search tree (BST)"""
    
    def __init__(self):
        """Constructor method"""
        self.root = None  # Initialise to None as the tree is empty
    
    def get_root(self):
        """Return the root node"""
        return self.root

  
    def insert(self, item):
        """Insert a new node"""

        # Create a new node
        new_node = Node(item)

        # Check if the root node exists
        if self.root is None:
            # Set the root to be the new node
            self.root = new_node

        # Find the correct place to insert the new node
        else:
            current = self.root
            placed = False

            # Repeat while the data has not been inserted            
            while placed == False:
                
                # Check if the new item is greater than the current node data
                if item > current.get_data():
                    # Check if the current node does not have a right child node
                    if current.get_right() is None:
                        # Insert the new node to the right of the current node
                        current.set_right(new_node)
                        placed = True
                    # Otherwise repeat with the current right node
                    else:
                        current = current.get_right()

                # Otherwise the new item is less than or equal to the current node
                else:
                    # Check if the current node does not have a left child node
                    if current.get_left() is None:
                        # Insert the new node to the left of the current node
                        current.set_left(new_node)
                        placed = True
                    # Otherwise repeat with the current left node
                    else:
                        current = current.get_left()          

    
    def pre_order_traversal(self, node):
        """A pre-order traversal of the binary search tree"""

        # Output the data of the current node
        print(node.get_data())

        # Check any nodes to the left of the current node
        if node.get_left() is not None:
            self.pre_order_traversal(node.get_left())
        
        # Check any nodes to the right of the current node
        if node.get_right() is not None:
            self.pre_order_traversal(node.get_right())
            

def insert_test_data(bst):
    """"Insert test data into the binary search tree"""
    bst.insert(8)  # This will be the root node
    bst.insert(3)
    bst.insert(6)
    bst.insert(10)
    bst.insert(1)
    bst.insert(5)
    bst.insert(18)
    bst.insert(7)
    bst.insert(12)


def output_tree(node, level = 0):
    """Print the tree with the root to the left and children to the right"""

    if node is not None:
        output_tree(node.get_right(), level + 1)
        print(' ' * 4 * level + '-> ' + str(node.get_data()))
        output_tree(node.get_left(), level + 1)


def main():
    """Create a binary search tree and search for an item"""

    # Instantiate a new tree object
    bst = BST()

    # Insert test data into the binary search tree
    insert_test_data(bst)

    # Get the root node
    root = bst.get_root()

    # Testing
    print("### Output the tree structure ###")
    print("The root is the left-most value and the children are to the right\n")
    output_tree(root)

    # Output the binary search tree using a pre-order traversal
    print("\n### Binary search tree (pre-order traversal) ###")
    bst.pre_order_traversal(root)
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
