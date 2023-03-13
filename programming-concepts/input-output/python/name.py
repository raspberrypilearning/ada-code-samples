# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    print("What is your name?")
    name = input()
    print(f"Hello {name}")

"""
Lines 6 and 7 can be combined into a single line of code:
name = input("What is your name?")
"""

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main() 