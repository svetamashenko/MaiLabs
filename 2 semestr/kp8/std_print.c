/*
 * Печать списка, начиная с барьерного элемента
 */
#include "data.h"

void std_print(struct cell *tmp)
{
    if (tmp)
    {
        printf("%s\n", (tmp->value == wizard) ? "wizard" : (tmp->value == celstial) ? "celstial" : (tmp->value == groovein) ? "groovein" : (tmp->value == blademaster) ? "blademaster" : "valkyrie");
        if (tmp->next)
        {
            struct cell *runner = tmp->next;
            while (runner != tmp)
            {
                printf("%s\n", (runner->value == wizard) ? "wizard" : (runner->value == celstial) ? "celstial" : (runner->value == groovein) ? "groovein" : (runner->value == blademaster) ? "blademaster" : "valkyrie");
                if (runner->next)
                {
                    runner = runner->next;
                }
                else
                {
                    return;
                }
            }
        }
    }
    else
    {
        printf("Team is empty\n");
    }
    return;
}