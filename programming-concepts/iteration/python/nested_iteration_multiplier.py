# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def main():
   for num in range(1,4):
      for multiplier in range(1,11):
          result = num * multiplier
          print(f"{num} * {multiplier} = {result}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
