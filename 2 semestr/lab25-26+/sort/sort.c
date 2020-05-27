#include <stdio.h>
#include "sort.h"

void sort(int *stack, int first, int count)
{
    int *stnew;
    int i = first;
    int j = count;
    int o;
    int x = stack[(first + j) / 2];
    do
    {
        while (stack[i] < x)
            i++;
        while (stack[j] > x)
            j--;
        if (i <= j)
        {
            if (stack[i] > stack[j])
                change(stack, i, j);
            i++;
            j--;
        }
    } while (i <= j);

    if (i < count)
        sort(stack, i, count);
    if (first < j)
        sort(stack, first, j);
}

void change(int *stack, int i, int j)
{
    int c = stack[i];
    stack[i] = stack[j];
    stack[j] = c;
}