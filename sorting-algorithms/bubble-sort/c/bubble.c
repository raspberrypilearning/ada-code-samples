#include <stdio.h>
#include <stdbool.h>

// array to be sorted
int data[] = { 5,2,6,1134,13413,54,1,6,89,23,6,8,34,73,4,327,5,324 };

// bubble sort function
void bubble(int *array, int size){
    int i = 0;
    int j = 0;
    int temp = 0;
    bool swapped = true;
    while(swapped){
        swapped = false;
        for (size_t i = 0; i < size-1; i++){
            if (array[i] > array[i+1]){
                temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
                swapped = true;
            }
        }
    }
    for (size_t i = 0; i < size; i++){
        printf("%d ", array[i]);
    }
    
}

void main(){
    bubble(data, sizeof(data)/sizeof(data[0]));
}

// Credit: Michael Parker https://mastodon.social/@michaelparker