#ifndef DATA_H
#define DATA_H
#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#define type_name enum sign

#define Sign(new_val) (new_val == 1) ? wizard : (new_val == 2) ? celstial : (new_val == 3) ? groovein : (new_val == 4) ? blademaster : valkyrie

#define Cret(tmp, type)                   \
    tmp = (type *)malloc(sizeof(type *)); \
    if (!tmp)                             \
    {                                     \
        printf("Out of memory\n");        \
    }

type_name // Ведьмачьи знаки)))
{
    wizard,
    celstial,
    groovein,
    blademaster,
    valkyrie
} value;

typedef struct cell
{
    type_name value;

    struct cell *next;
    struct cell *prev;
} cell;

void std_print(struct cell *);
int std_size(struct cell *);
struct cell *std_insert(struct cell *, type_name);
struct cell *std_delete(struct cell *, type_name);
struct cell *unstd_act(struct cell *, type_name, int);
#endif