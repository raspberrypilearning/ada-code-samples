#include <stdio.h>
#include <string.h>

int is_palindrome(char *str, int start, int end) {
    // Recursively determines whether a word is a palindrome. Returns a Boolean.
    if (start >= end) {
        return 1;
    }
    if (str[start] != str[end]) {
        return 0;
    }
    return is_palindrome(str, start + 1, end - 1);
}

int main() { // Driver code test cases
    printf("kayak is %d\n", is_palindrome("kayak", 0, strlen("kayak") - 1));
    printf("racecar is %d\n", is_palindrome("racecar", 0, strlen("racecar") - 1));
    printf("hello is %d\n", is_palindrome("hello", 0, strlen("hello") - 1));
    printf("\n");
    printf("kayak is %s\n" , is_palindrome("kayak", 0, strlen("kayak") - 1) ? "true" : "false");
    printf("racecar is %s\n" , is_palindrome("racecar", 0, strlen("racecar") - 1) ? "true" : "false");
    printf("hello is %s\n" , is_palindrome("hello", 0, strlen("hello") - 1) ? "true" : "false");
}

// Credit: Michael Parker https://mastodon.social/@michaelparker