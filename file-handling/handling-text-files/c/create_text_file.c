#include <stdio.h>

//demo of appending to a file

void create_text_file(char* filename)
{
    FILE* fptr;
    fptr = fopen(filename, "w"); // w is for write when opening a file
    if (fptr == NULL)
    {
        printf("Error!");
        return;
    }
}

int main(void)
{
    create_text_file("file.txt");
    return 0;
}