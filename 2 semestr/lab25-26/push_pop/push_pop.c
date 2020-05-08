#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include "push_pop.h"
#include "../data.h"

int *push(int add, int *stack, int count)
{
    if (!stack[count])
        stack = (int *)realloc(stack, count * sizeof(int));
    stack[count] = add;
    return stack;
}

int *pop(int *stack, int count)
{
    stack[count] = 0;
    return stack;
}