# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

import csv 

def read_records():
    """Read and display the records from a CSV file"""
    # Initialise the filename and count
    filename = "movies_extra.csv";
    count = 0

    # Open the file in read mode using the with command
    with open(filename, mode="r") as file_object:
        # Use the csv library to read the file and specify the delimiter
        csv_reader = csv.reader(file_object, delimiter=",")
        for line in csv_reader:
            if count == 0:  # Process header record
                print(f"Header: {line[0]}, {line[1]}, {line[2]}, {line[3]}, {line[4]}, {line[5]}, {line[6]}")
            else:  # Process data record
                print(f"Data: {line[0]}, {line[1]}, {line[2]}, {line[3]}, {line[4]}, {line[5]}, {line[6]}")
            count = count + 1


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    read_records()
