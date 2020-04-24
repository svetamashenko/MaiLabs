#include <stdio.h>
#include "function.h"
#include "../data.h"

void convert(cell *tmp)
{
    if (((tmp->left->val.oper) == '*') && ((tmp->type) == 1) && ((tmp->left->right->type) == 0))
    {
        int k = (tmp->left->val.value);
        for (int i = 1; i < k; i++)
        {
            if ((tmp->left->val.value) != 0)
            {
                tmp->right->right->right = tmp->right;
                tmp->right->left = tmp->left->left;
                tmp->right->parent = tmp;
                tmp->right->type = tmp->left->type;
                tmp->right->val.oper = tmp->left->val.oper;
                tmp->right->right = tmp;
                (tmp->left->right->val.value)--;
            }
            else
                cleaner(tmp);
        }
    }
    if (((tmp->left->val.oper) == '*') && ((tmp->type) == 0) && ((tmp->left->right->type) == 1))
    {
        int c = tmp->left->right->val.value;
        tmp->left->right->val.oper = tmp->val.oper;
        tmp->val.value = c;
        tmp->left->right->type=0;
        tmp->type = 1;
        convert(tmp);
    }
}

void cleaner(cell *tmp)
{
    if (tmp->left)
        cleaner(tmp->left);
    if (tmp->right)
        cleaner(tmp->right);
    free(tmp);
}