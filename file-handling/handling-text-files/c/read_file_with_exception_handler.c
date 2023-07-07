#include <stdio.h>

void create_text_file(char* filename){
    FILE* fptr;
    fptr = fopen(filename, "r");
    if (fptr == NULL)
    {
        printf("Error!");
        return;
    }
    char c = fgetc(fptr);
    
    while (c != EOF)
    {
        printf("%c", c);
        c = fgetc(fptr);
    }
    fclose(fptr);

}

int main(void)
{
    create_text_file("playlist.txt");
    return 0;
}