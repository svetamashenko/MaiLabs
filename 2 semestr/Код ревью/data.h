#ifndef DATA_H
#define DATA_H
#include <stdio.h>
#include <stdlib.h>
#define cell struct cell

typedef cell
{
    cell *parent;
    cell *left;
    cell *right;

    short type;

    union invent
    {
        int value;
        char oper;
    }
    val;
}
this_cell;

#endif