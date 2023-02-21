# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
     

def read_file():
    """Read and display all records from a file"""
    with open("playlist.txt", mode = "r") as playlist:
        for track in playlist:
            print(track)   
    

if __name__ == "__main__":
    read_file()

    
