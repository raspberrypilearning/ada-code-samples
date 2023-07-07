#include <stdio.h>

void RLE(char* str)
{
    char* p = str;
    int count = 1;
    while (*p != '\0') {
        if (*p == *(p+1)) {
            count++;
        } else {
            printf("%d%c", count, *p);
            count = 1;
        }
        p++;
    }
    
}

int main(void) {
    char str[] = "aaabbcd";
    RLE(str);
    return 0;
}

// Credit: Michael Parker https://mastodon.social/@michaelparker