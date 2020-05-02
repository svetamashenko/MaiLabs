#include <stdio.h>
#include <stdlib.h>
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

#define new_br(new)                                    \
    Cret(new->right, cell);                            \
    new->right->parent = new;                          \
    new = new->right;                                  \
    Cret(new->right, cell);                            \
    new->right->parent = new;                          \
    new = new->right;                                  \
    new->parent->type = 0;                             \
    new->parent->parent = new->parent->parent->parent; \
    new->parent->val.oper = '+';                       \
    new->parent->right = new;                          \
    new->parent->left = NULL;                          \
    new->right = NULL;                                 \
    new->left = NULL;                                  \
    if (tmp->type == 1)                                \
    {                                                  \
        new->val.value = tmp->val.value;               \
        new->type = 1;                                 \
    }                                                  \
    else                                               \
    {                                                  \
        new->val.oper = tmp->val.oper;                 \
        new->type = 0;                                 \
    }                                                  \
    k++;

void convertor(cell *tmp)
{
    int mnoj;
    if (tmp->parent && (tmp->parent->type == 1 || (tmp->parent->type == 0 && ((tmp->parent->val.oper > 64 && tmp->parent->val.oper < 91) || (tmp->parent->val.oper > 96 && tmp->parent->val.oper < 123)))) && tmp->type == 0 && tmp->val.oper == '*' && tmp->right)
    {
        if (tmp->right->type == 1 && tmp->right->val.value > 0)
        {
            if (!tmp->right->right && !tmp->right->left)
            {
                if (tmp->left)
                {
                    mnoj = tmp->right->val.value;
                    cell *del, *del1;
                    del = tmp;
                    del1 = del->right;
                    tmp = tmp->parent;
                    tmp->left->left->parent = tmp;
                    tmp->left = tmp->left->left;
                    free(del);
                    free(del1);
                }
                else
                {
                    mnoj = tmp->right->val.value;
                    tmp = tmp->parent;
                    free(tmp->left->right);
                    free(tmp->left);
                    tmp->left = NULL;
                }
                cell *present = tmp, *down = tmp, *new, *help;
                if (tmp->right)
                {
                    down = tmp->right;
                }
                int k = 0;
                if (mnoj > 1)
                {
                    Cret(new, cell);
                    Cret(new->parent, cell);
                    new->parent->type = 0;
                    new->parent->parent = NULL;
                    new->parent->val.oper = '+';
                    new->parent->right = new;
                    new->parent->left = NULL;
                    new->right = NULL;
                    new->left = NULL;
                    if (tmp->type == 1)
                    {
                        new->val.value = tmp->val.value;
                        new->type = 1;
                    }
                    else
                    {
                        new->val.oper = tmp->val.oper;
                        new->type = 0;
                    }
                    help = new;
                    while (k < mnoj - 2)
                    {
                        new = help;
                        new_br(new);
                        help = new;
                    }
                    while (new->parent)
                    {
                        new = new->parent;
                    }
                    tmp->right = new;
                    new->parent = tmp;
                    while (new->right)
                    {
                        new = new->right;
                    }
                    if (down != tmp)
                    {
                        down->parent = new;
                        new->right = down;
                    }
                }
            }
        }
    }
    if (tmp->left)
    {
        convertor(tmp->left);
    }
    if (tmp->right)
    {
        convertor(tmp->right);
    }
    return;
}