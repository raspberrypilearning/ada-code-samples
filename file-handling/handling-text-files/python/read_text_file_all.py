# Isaac Computer Science
# Usage licensed under the Open Government Licence v3.0

     
def read_file():
    """Example of reading in a whole file"""
    file_object = open("bridge.txt", mode="r")
    rhyme = file_object.read()
    file_object.close()
    print(rhyme)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    read_file()   
