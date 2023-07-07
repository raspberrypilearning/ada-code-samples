#include <stdio.h>

int sum_to_n(int n){
    if (n == 1){
        return 1;
    }
    return n + sum_to_n(n - 1);
    
}

void main(void){
    int n = 5;
    int sum = sum_to_n(n);
    printf("Sum of 1 to %d is %d\n", n, sum);
}

// Credit: Michael Parker https://mastodon.social/@michaelparker