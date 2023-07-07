#include <stdio.h>

int to_search[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 55};


int binary_search(int to_search[], int size, int value)
{
    int low = 0;
    int high = size - 1;
    int mid = 0;
    while (low <= high)
    {
        mid = (low + high) / 2;
        if (to_search[mid] == value)
        {
            return mid;
        }
        else if (to_search[mid] < value)
        {
            low = mid + 1;
        }
        else
        {
            high = mid - 1;
        }
    }
    return -1;
}

void main()
{
    int value = 0;
    printf("What number should we search for: ");
    scanf("%d", &value);
    int index = binary_search(to_search, sizeof(to_search) / sizeof(int), value);
    if (index == -1)
    {
        printf("The number %d was not found in the array \n", value);
    }
    else
    {
        printf("The number %d was found at index %d \n", value, index);
    }
}