#include <stdio.h>

int sum_to_n_recursive(int n)
{
    int total = 0;
    for (int i = 1; i <= n; i++)
    {
        total += i;
    }
    return total;
}

void main(void)
{
    int n = 5;
    int sum = sum_to_n_recursive(n);
    printf("Sum of 1 to %d is %d\n", n, sum);
}

// Credit: Michael Parker https://mastodon.social/@michaelparker