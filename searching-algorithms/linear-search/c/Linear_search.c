#include <stdio.h>

int to_search[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10,55};

int Linear_Search(int to_search[], int size, int value)
{
    for (int i = 0; i < size; i++)
    {
        if (to_search[i] == value)
        {
            return i;
        }
    }
    return -1;
}

void main()
{
    int value = 0;
    printf("What number should we search for: ");
    scanf("%d", &value);
    int index = Linear_Search(to_search, sizeof(to_search) / sizeof(int), value);
    if (index == -1)
    {
        printf("The number %d was not found in the array \n", value);
    }
    else
    {
        printf("The number %d was found at index %d \n", value, index);
    }
}
