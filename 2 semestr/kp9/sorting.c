#include <stdio.h>
#include <malloc.h>
#include "data.h"

void sorting(row *tmp, int size)
{
    for(int i=0; i<size;i++){
        printf("%s\n", tmp[i].string);
    }

    int j;
    row f;
    for (int step = size / 2; step > 0; step /= 2)
        for (int i = step; i < size; i++)
        {
            f.key = tmp[i].key;
            for (j = i; j >= step; j -= step)
            {
                if (f.key < tmp[j - step].key)
                    tmp[j] = tmp[j - step];
                else
                    break;
            }
            tmp[j] = f;
        }
    for(int i=0; i<size;i++){
        printf("%s\n", tmp[i].string);
    }
    return;
}