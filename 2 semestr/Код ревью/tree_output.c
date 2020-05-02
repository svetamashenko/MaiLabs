#include <stdio.h>
#include "data.h"
#include "tree_output.h"

enum TYPES//Вместо 0 и 1 в типах используйте enum
{
    CHAR = 0,
    INT = 1
};

void text_out(cell *tmp)
{
  
}

void tree_out(cell *tmp, int space)
{
    int i = space;
    if (tmp->right)
    {
        tree_out(tmp->right, space + 1);
    }
    printf("%d", i);

    while (i > 0)
    {
        printf("%s", "__");
        i--;
    }

    if (tmp->type == INT)
        printf("%d\n", tmp->val.value);//почему тут нет скобок....
    else
        printf("%c\n", tmp->val.oper);
        
    i--;
    if (tmp->left)
    {//....а тут есть? У кого такая безвкусица
        tree_out(tmp->left, space + 1);
    }
}

