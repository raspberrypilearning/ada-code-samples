# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def create_playlist():
    """Create a new playlist CSV file with a header record"""
    header = "Title,Artist,Duration"
    file_object = open("playlist.csv", mode="w")
    file_object.write(header)
    file_object.write("\n")
    file_object.close()


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    create_playlist()
