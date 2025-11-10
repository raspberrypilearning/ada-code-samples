#include <stdio.h>

int nth_term(int n,int increment) { //Recursively calculates and returns the value of nth term of an AP
    if (n == 1) {
        return 1;
    }
    return increment + nth_term(n - 1,increment);
}

int main() {  // Driver code
    int n = 10;
    int increment = 6;
    printf("The %dth term is %d\n", n, nth_term(n,increment));
    return 0;
}


// Credit: Michael Parker https://mastodon.social/@michaelparker