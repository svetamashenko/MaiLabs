#include <stdio.h>
#include <malloc.h>
#include "../data.h"
#include "function.h"

void convertor(cell *tmp)
{
    if (((tmp->left->val.oper) == '*') && ((tmp->type) == 1) && ((tmp->left->right->type) == 0))
    {
        int k = (tmp->val.value);
        for (int i = 1; i < k; i++)
        {
            if ((tmp->val.value) != 0)
            {
                if ((!tmp->right->right->right) && (tmp->right->right) && (tmp->right))
                {
                    tmp->right->right->right = (cell *)malloc(sizeof(cell));

                    if (!tmp)
                        printf("%s\n", "Out of meme");
                    tmp->right->right->right = tmp->right;
                }
                if (!tmp->right)
                    tmp->right = (cell *)malloc(sizeof(cell));
                tmp->right->left = tmp->left->left;
                tmp->right->parent = tmp;
                tmp->right->type = tmp->left->type;
                tmp->right->val.oper = tmp->left->val.oper;
                tmp->right->right = tmp;
                (tmp->val.value)--;
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
        tmp->left->right->type = 0;
        tmp->type = 1;
        convertor(tmp);
    }
    convertor(tmp->left);
    convertor(tmp->right);
}

void cleaner(cell *tmp)
{
    if (tmp->left)
        cleaner(tmp->left);
    if (tmp->right)
        cleaner(tmp->right);
    free(tmp);
}