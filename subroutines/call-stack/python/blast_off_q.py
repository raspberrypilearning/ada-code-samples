# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4


def blast_off(n):
    """Count down timer"""

    if n == 0:
        print("Blast off!")
    else:
        print(n)
        blast_off(n-1)


def main():
    blast_off(5)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
