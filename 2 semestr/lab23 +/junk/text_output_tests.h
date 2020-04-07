#ifndef TEXT_OUTPUT_H
#define TEXT_OUTPUT_H

#include <stdio.h>
#include "data.h"
#include <math.h>

/*void output(cell *curr)
{
    cell *root = curr;
    int n = 1;
    printf("%s\n\n", "Your tree: ");
    while (!(*curr).right)
    {
        curr = (*curr).right;
        n++;
    }
    int k = n;
    while (n != 0)
    {
        for (int i = k; i < k; i = i - 1) //отступ вниз
            printf("%s\n", "  ");
        for (int i = 1; i <= 2*n; i++)//отступ вправо
            printf("%s", " ");
        printf("%c\n", (*(*curr).right).value);
        for (int i = k + 1; i < k; i = i - 1)
            printf("%s\n", "  ");
        for (int i = 1; i <= 2*(n - 1); i++)
            printf("%s", " ");
        printf("%c\n", (*curr).value);
        for (int i = k + 2; i < k; i = i - 1)
            printf("%s", " "); 
        for (int i = 1; i <= 2*n ; i++)
            printf("%c\n", (*(*curr).left).value);
        
    }
}*/

void output(cell *tmp)
{
    cell *count = tmp;
    printf("%s\n", "Your tree was buit:");
    int widel = 1, wider = 1;
    while ((*count).left != NULL)
    {
        widel++;
        *count = *(*count).left;
    }
    while ((*count).right != NULL)
    {
        wider++;
        *count = *(*count).right;
    }
    int wide = widel + wider - 1;
    printf("%d\n", wide);
    for (int i = widel; i > 0; i -= 1)
    {
        if (i == widel)
        {
            printf("%s\n", "Step 1:");
            int deep = i;
            for (int i = 1; i != widel; i++)
                printf("%s", "  ");
            printf("%c\n", (*tmp).value);
        }
        else if (i < widel)
        {
            printf("%s\n", "Step 2:");
            for (int i = 1; i < ((wide / pow(2, i)) - i); i++)
                printf("%s", "  ");
            int t = i;
            printf("%c\n", (*(*tmp).left).value);
            for (int i = 1; i < t * pow(2, i); i++)
                printf("%s", " ");
            printf("%c\n", (*(*tmp).right).value);
            printf("\n");
        }
    }
}

#endif