# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def check_password(password):
    """Checks that a password length is at least 8"""
    is_valid = True
    if len(password) < 8:
        is_valid = False
    return is_valid


def main():
    # normal test data
    password = "elephant1234"
    result = check_password(password)
    print(f"{password} is valid: {result}")
    
    # boundary test data 
    password = "elephant" # 8 characters
    result = check_password(password)
    print(f"{password} is valid: {result}")  
    
    # password too short
    password = "1234" # 4 characters
    result = check_password(password)
    print(f"{password} is valid: {result}")
    

# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
