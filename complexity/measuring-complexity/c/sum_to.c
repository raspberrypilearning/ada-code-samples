#include <stdio.h>


int sum_to(int num) //Calculates the sum of all integers from 1 to the given number
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
    
}

int main(void)
{
    //test cases
    printf("Sum of 1 to 5 is %d\n", sum_to(5));
    printf("Sum of 1 to 10 is %d\n", sum_to(10));
}