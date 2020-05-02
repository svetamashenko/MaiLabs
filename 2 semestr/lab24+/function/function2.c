#include <stdio.h>
#include <malloc.h>
#include "../data.h"
#include "function.h"
#include "../cleaner/cleaner.h"
#define Cret(tmp, type)                 \
    tmp = (type *)malloc(sizeof(type)); \
    if (!tmp)                           \
    {                                   \
        printf("%s\n", "Out of meme");  \
        return;                         \
    }

void convertor(cell *tmp)
{
    if (!tmp->left)
    {
        if (!tmp->right)
            return;
        else
            convertor(tmp->right);
        return;
    }
    else if (!tmp->left->right)
    {
        convertor(tmp->right);
        return;
    }
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
                    cell *remember = tmp;
                    cell *moving;
                    Cret(moving, cell);
                    moving->parent = NULL;
                    moving->right = tmp->right->right;
                    moving->left = tmp->right->left;
                    moving->type = tmp->right->type;
                    moving->val = tmp->right->val;
                    while ((tmp->right) && (tmp->right->right))
                    {
                        Cret(moving->right, cell);
                        moving->right->parent = moving;
                        moving = moving->right;
                        tmp = tmp->right;
                        moving->right = tmp->right->right;
                        moving->left = tmp->right->left;
                        moving->type = tmp->right->type;
                        moving->val = tmp->right->val;
                    }
                    while (moving->parent)
                        moving = moving->parent;
                    tmp = remember;
                    if (!tmp->right->right)
                    {
                        Cret(tmp->right->right, cell);
                        Cret(tmp->right->right->right, cell);
                    }
                    if ((tmp->right->right) && (!tmp->right->right->right))
                        Cret(tmp->right->right->right, cell);
                    tmp->right->right->right = moving;
                    tmp->right->right->right->parent = tmp->right->right;
                    tmp->right->left = NULL;
                    tmp->right->type = tmp->right->right->type = tmp->left->type;
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
                clean(tmp->left);
                tmp->left->right = NULL;
                tmp->left = NULL;
                k = 0;
            }
        }
    }
    if (tmp->left)
        convertor(tmp->left);
    if (tmp->right)
        convertor(tmp->right);
    return;
}