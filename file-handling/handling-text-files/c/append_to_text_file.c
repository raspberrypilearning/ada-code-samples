#include <stdio.h>

//demo of appending to a file

void append_to_file(char* filename, char* str)
{
    FILE* fptr;
    fptr = fopen(filename, "a"); // a is for append when opening a file
    if (fptr == NULL)
    {
        printf("Error!");
        return;
    }
    fprintf(fptr, "%s\n", str); // this is the line that appends to the file
    fclose(fptr);
}

int main(void)
{
    append_to_file("file.txt", "hello");
    append_to_file("file.txt", "world");
    return 0;
}