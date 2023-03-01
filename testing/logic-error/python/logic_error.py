# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_vat(amount):
    """Calculates and applies VAT at standard rate"""

    # Demonstrates a logic error
    RATE = 20
    vat = amount * RATE
    with_vat = amount + vat
    return with_vat


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    amount = 130.4
    result = add_vat(amount)
    print(result)
