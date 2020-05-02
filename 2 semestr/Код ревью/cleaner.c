#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include "data.h"
#include "cleaner.h"

cell *ascencion(cell *tmp)
{
    while (tmp->parent)
        tmp = tmp->parent;
}

void clean(cell *tmp)
{
    if (tmp->left)
        clean(tmp->left);
    if (tmp->right)
        clean(tmp->right);
    free(tmp);
}

void clean_tree(cell *tmp)
{
    if(tmp){//кто так скобочки поставил и забил на табуляцию, тот гоблин
    tmp = ascencion(tmp);
    clean(tmp);
    }
}
