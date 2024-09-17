#include <stdio.h>

int factorial(int n) { //Recursively calculates and returns the value of n!
    if (n == 0) {
        return 1;
    }
    return n * factorial(n - 1);
}

int main() {  // Driver code
    int n = 5;
    printf("%d! is %d\n", n, factorial(n));
    return 0;
}

// Credit: Michael Parker https://mastodon.social/@michaelparker