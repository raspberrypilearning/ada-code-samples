# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4


def check_password(password):
    """Checks that a password length is between 8 and 14 characters. Returns True if valid"""

    is_valid = True
    
    if len(password) < 8 or len(password) > 14:
        is_valid = False
        
    return is_valid


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    password_to_check = "test"
    result = check_password(password_to_check)
    print(f"Valid password? {result}")
