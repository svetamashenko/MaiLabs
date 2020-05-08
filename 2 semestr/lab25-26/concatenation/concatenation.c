#include <stdio.h>
#include <malloc.h>
#include "concatenation.h"

int *concatenation(int *stack1, int count1, int *stack2, int count2)
{
    stack1 = (int *)realloc(stack1, sizeof(stack1)+count2*sizeof(int));
    int j = 0;
    while (j <= count2)
    {
        stack1[count1 + j] = stack2[j];
        j++;
    }
    return stack1;
}