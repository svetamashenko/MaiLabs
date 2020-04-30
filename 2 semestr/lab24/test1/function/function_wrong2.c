#include <stdio.h>
#include <malloc.h>
#include "../data.h"
#include "function.h"
#define Cret(tmp, type)                 \
    tmp = (type *)malloc(sizeof(type)); \
    if (!tmp)                           \
    {                                   \
        printf("%s\n", "Out of meme");  \
        return;                         \
    }

void convertor(cell *tmp)
{
    if (((!tmp->right) && (!tmp->left)) || (!tmp->left) || ((tmp->left) && (!tmp->left->right)))
        return;
    if (((tmp->left->val.oper) == '*') && ((tmp->type) == 1) && ((tmp->left->right->type) == 0))
    {
        int c = tmp->val.value;
        tmp->val.oper = tmp->left->right->val.oper;
        tmp->left->right->val.value = c;
        tmp->type = 0;
        tmp->left->right->type = 1;
        convertor(tmp);
    }
    if (((tmp->left->val.oper) == '*') && ((tmp->type) == 0) && ((tmp->left->right->type) == 1) && ((!tmp->left->right->left) || (tmp->left->right->left->val.oper != '*')))
    {
        int k = (tmp->left->right->val.value);
        for (int i = 0; i < k; i++)
        {
            if (tmp->left->right->val.value != 1)
            {
                if (tmp->right)
                {
                    int *right = &(tmp->right->right);
                    int *left = &(tmp->right->left);
                    int type = tmp->right->type;
                    int val1 = tmp->val.value;
                    int val0 = tmp->val.oper;
                    if ((!tmp->right->right) && (!tmp->right->right->right))
                    {
                        Cret(tmp->right->right, cell);
                        Cret(tmp->right->right->right, cell);
                    }
                    if ((tmp->right->right) && (!tmp->right->right->right))
                    {
                        Cret(tmp->right->right->right, cell);
                    }
                    tmp->right->right->right->right = right;
                    tmp->right->right->right->parent = tmp->right->right;
                    tmp->right->right->right->left = left;
                    tmp->right->right->right->type = type;
                    tmp->right->right->right->val.oper = val0;
                    tmp->right->right->right->val.value = val1;
                    if (tmp->left->left)
                        tmp->right->left = tmp->left->left;
                    else
                        tmp->right->left = NULL;
                    tmp->right->type = tmp->left->type;
                    tmp->right->val.oper = '+';
                    tmp->right->right->val.oper = tmp->val.oper;
                    (tmp->left->right->val.value)--;
                }
                else
                {
                    Cret(tmp->right, cell);
                    tmp->right->parent = tmp;
                    tmp->right->right = NULL;
                    tmp->right->left = NULL;
                    tmp->right->type = 0;
                    tmp->right->val.oper = '+';
                    Cret(tmp->right->right, cell);
                    tmp->right->right->parent = tmp->right;
                    tmp->right->right->left = NULL;
                    tmp->right->right->right = NULL;
                    tmp->right->right->type = 0;
                    tmp->right->right->val.oper = tmp->val.oper;
                    (tmp->left->right->val.value)--;
                }
            }
            else
            {
                cleaner(tmp->left);
                tmp->left = NULL;
                k = 0;
            }
        }
    }
    if (tmp->left)
        convertor(tmp->left);
    if (tmp->right)
        convertor(tmp->right);
}

void cleaner(cell *tmp)
{
    if (tmp->left)
    {
        cleaner(tmp->left);
    }
    if (tmp->right)
    {
        cleaner(tmp->right);
    }
    free(tmp);
}