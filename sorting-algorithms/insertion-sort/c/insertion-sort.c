#include <stdio.h>

int to_search[] = {1, 55, 2, 3, 4, 5, 6, 7, 8, 9, 10};	

int insertion_sort(int *array, int size){
    int i = 0;
    int j = 0;
    int temp = 0;
    for (size_t i = 0; i < size; i++){
        j = i;
        while(j > 0 && array[j-1] > array[j]){
            temp = array[j];
            array[j] = array[j-1];
            array[j-1] = temp;
            j--;
        }
    }
    for (size_t i = 0; i < size; i++){
        printf("%d ", array[i]);
    }
}

void main(){
    insertion_sort(to_search, sizeof(to_search)/sizeof(int));
}
