#include <stdio.h>

int gcd(int a, int b) 
{ //Recursively calculates and returns the value of gcd(a, b)
    if (b == 0) {
        return a;
    }
    return gcd(b, a % b);
}

void main(){ // Driver code
    int x = 259, y = 111;
    printf("gcd(%d, %d) is %d\n", x, y, gcd(x, y));

}

// Credit: Michael Parker https://mastodon.social/@michaelparker