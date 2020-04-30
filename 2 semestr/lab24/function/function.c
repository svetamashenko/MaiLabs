#include <stdio.h>
#include <malloc.h>
#include "../data.h"
#include "function.h"
#define tmppp tmp->parent->parent
#define tmpprr tmp->parent->parent->right->right
#define Cret(tmp, type)                 \
    tmp = (type *)malloc(sizeof(type)); \
    if (!tmp)                           \
    {                                   \
        printf("%s\n", "Out of meme");  \
        return tmp;                     \
    }

void convertor(cell *tmp)
{
    while ((tmp->right) || (tmp->left))
        tmp = tmp->left;

    if (((tmp->parent->val.oper) == '*') && ((tmp->type) == 1) && ((tmppp->type) == 0))
    {
        int k = (tmp->val.value);
        for (int i = 1; i < k; i++)
        {
            if ((tmp->left->right->val.value) != 0)
            {
                if (tmppp->right)
                {
                    if ((!tmpprr->right) && (!tmpprr))
                    {
                        Cret(tmpprr, cell *);
                        Cret(tmpprr->right, cell *);
                    }
                    if ((!tmpprr->right) && (tmpprr))
                    {
                        Cret(tmpprr->right, cell *);
                    }
                    tmpprr->right = tmppp->right;
                    tmppp->right->left = tmppp->left->left;
                    tmppp->right->parent = tmppp;
                    tmppp->right->type = tmppp->left->type;
                    tmppp->right->val.oper = '+';
                    tmpprr = tmppp;
                    (tmp->val.value)--;
                }
                else
                {

                }
            }
            else
                cleaner(tmp);
        }
    }

    if (((tmp->left->val.oper) == '*') && ((tmp->type) == 1) && ((tmp->left->right->type) == 0))
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