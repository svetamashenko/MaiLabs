
#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include "data.h"
#include "function.h"

enum TYPES//Вместо 0 и 1 в типах используйте enum
{
    CHAR = 0,
    INT = 1
};

void func(cell *tmp)//Функция func? кому 5 баллов за креативность?
{
    if (tmp->type == CHAR && tmp->val.oper == '/' && tmp->right)
    {// if if if if вы серьезно? перепишите нормально
        if (tmp->right->type == INT && tmp->right->val.value == INT)
        {
            if (!tmp->right->right && !tmp->right->left)
            {
                if (tmp->left)
                {
                    cell *del, *del1;//del вообще ключевое слово в некоторых языках, нельзя его использовать
                    //как переменную
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
                    tmp = tmp->parent;
                    free(tmp->left->right);
                    free(tmp->left);
                    tmp->left = NULL;
                }
            }
        }
    }
    if (tmp->left)
    {
        func(tmp->left);
    }
    if (tmp->right)
    {
        func(tmp->right);
    }
    return;
}

