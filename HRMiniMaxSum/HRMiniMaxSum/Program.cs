#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int main()
{
    int* arr = malloc(sizeof(int) * 5);
    for (int arr_i = 0; arr_i < 5; arr_i++)
    {
        scanf("%d", &arr[arr_i]);
    }
    return 0;
}