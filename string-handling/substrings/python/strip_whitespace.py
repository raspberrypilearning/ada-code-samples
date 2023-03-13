# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def strip_whitespace():
    """Demonstrates stripping whitespace from the start and end of a string"""
    my_string = "     Ada Computer Science  \n"
    stripped_string = my_string.strip()
    print(stripped_string)
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    strip_whitespace()
