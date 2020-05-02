#include <stdio.h>
#include "build.h"
#include <malloc.h>
#include "data.h"

enum TYPES //Вместо 0 и 1 в типах используйте enum
{
    CHAR = 0,
    INT = 1
};
// это выполняется много раз, делайте через функцию
//       tmp->parent = NULL;
//        tmp->left = NULL;
//        tmp->right = NULL;
//        tmp->type = INT;

//уберите ужасные #define везде, код невозможно читать
#define Cret(tmp, type)                 \
    tmp = (type *)malloc(sizeof(type)); \
    if (!tmp)                           \
    {                                   \
        printf("%s\n", "Out of meme");  \
        return tmp;                     \
    }

cell *add_int(int value, cell *tmp)
{
    if (!tmp)
    {
        Cret(tmp, cell);
        tmp->parent = NULL;
        tmp->left = NULL;//Повторение с разными параметрами
        tmp->right = NULL;
        tmp->type = INT;
        tmp->val.value = value;
        return tmp;
    }
    else
    {
        Cret(tmp->right, cell);
        tmp->right->val.value = value;
        tmp->right->right = NULL;//Повторение с разными параметрами
        tmp->right->left = NULL;
        tmp->right->type = INT;
        tmp->right->parent = tmp;
        return tmp->right;
    }
}

cell *add_char(char sign, cell *tmp)
{
    if (!tmp)
    {
        Cret(tmp, cell);
        tmp->parent = NULL;
        tmp->left = NULL;
        tmp->right = NULL;//Повторение с разными параметрами
        tmp->type = CHAR;
        tmp->val.oper = sign;
        return tmp;
    }
    else
    {

        if ((sign == '*') || (sign == '/')  || (sign == '^'))
        {
            Cret(tmp->left, cell);
            tmp->left->val.oper = sign;
            tmp->left->right = NULL;
            tmp->left->left = NULL;
            tmp->left->type = CHAR;
            tmp->left->parent = tmp;
            return tmp->left;//Повторение с разными параметрами
        }
        else if ((sign == '+') || (sign == '-'))
        {
            while (((tmp->parent) != NULL) && (!(tmp->left) || (tmp->right)) &&
                  !(tmp->val.oper == '(' && tmp->type == CHAR))
            {
                tmp = tmp->parent;
            }
            while ((tmp->right) != NULL)
            {
                tmp = tmp->right;
            }
            Cret(tmp->right, cell);
            tmp->right->val.oper = sign;
            tmp->right->right = NULL;
            tmp->right->left = NULL;
            tmp->right->type = CHAR;//Повторение с разными параметрами
            tmp->right->parent = tmp;
            return tmp->right;
        }
        else
        {
            Cret(tmp->right, cell);
            tmp->right->val.oper = sign;
            tmp->right->right = NULL;
            tmp->right->left = NULL;//Повторение с разными параметрами
            tmp->right->type = CHAR;
            tmp->right->parent = tmp;
            return tmp->right;
        }
    }
}