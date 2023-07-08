#include <stdio.h>

void print_backwards(char *str) { // Recursively prints a string backwards
    if (*str == '\0') {
        return;
    }
    print_backwards(str + 1); // Recursive call
    printf("%c", *str);
}

int main() { // Driver code
    char str[] = "Hello World!";
    print_backwards(str);
    return 0;
}

// Credit: Michael Parker https://mastodon.social/@michaelparker