#include <stdio.h>
#include "../data.h"

void range(cell *tmp, int value1, int value2)
{
    int check1, check2;
    cell *tmp2 = tmp;
    while (tmp2->right)
    {
        tmp2 = tmp2->right;
    }
    check2 = tmp2->value;

    while (tmp->left)
    {
        tmp = tmp->left;
    }
    check1 = tmp->value;
    if (check1 >= value1 && check2 <= value2)
    {
        printf("%s\n", "Tree is in range.");
        return;
    }
    printf("%s\n", "Tree isn`t in range.");
}
