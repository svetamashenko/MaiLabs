#include <stdio.h>
#include "../data.h"
#include "output.h"

void output(int *stack, int count)
{
    for (int i = 0; i < count; i++)
        printf("%d\n", stack[i]);
}