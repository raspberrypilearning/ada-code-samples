#include <stdio.h>

//demo of write to a file

void write_to_file(char* filename, char* str)
{
    FILE* fptr;
    fptr = fopen(filename, "w"); // w is for write when opening a file
    if (fptr == NULL)
    {
        printf("Error!");
        return;
    }
    fprintf(fptr, "%s\n", str); // this is the line that writes to the file
    fclose(fptr);
}

int main(void)
{
    write_to_file("file.txt", "hello");
    write_to_file("file.txt", "world");
    return 0;
}