#include <stdio.h>
#include "../data.h"
#include <math.h>

void text_out(cell *tmp, int space)
{
    int i = space;
    if (tmp->right)
    {
        text_out(tmp->right, space + 1);
    }
    while (i > 0)
    {
        printf("%s", "    ");
        i -= 1;
    }
    if (tmp->type == 1)
        printf("%d\n", tmp->val.value);
    else
        printf("%c\n", tmp->val.oper);
    i -= 1;
    if (tmp->left)
    {
        text_out(tmp->left, space + 1);
    }
}
