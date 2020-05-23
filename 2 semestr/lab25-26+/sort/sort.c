#include <stdio.h>
#include <malloc.h>
#include "sort.h"
#include "../push_pop/push_pop.h"

void sort(int *stack, int first, int count)
{
    int *stnew[count];
    int n = 0;
    int i = first;
    int j = count;
    int x = stack[(first + j) / 2];
    do
    {
        while (stack[i] < x)
        {
            i++;
        }
        while (stack[j] > x)
            for (int k = 0; k < j; k++)
                *stnew = *push(stack[i], stnew[k], n);
        *stack = *pop(stack[i], count - 1);
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