#include <stdio.h>
#include "decomplect.h"
#include "../re_builder/re_builder.h"
#include "../data.h"
#include <malloc.h>
#define Cret(tmp, type)                 \
    tmp = (type *)malloc(sizeof(type)); \
    if (!tmp)                           \
    {                                   \
        printf("%s\n", "Out of meme");  \
        return;                         \
    }

void function(select_type *computer)
{
    if ((computer->proc.count == 0) || (computer->video.memory == 0) || (computer->hdd.count == 0) || (computer->ctrl.discrete == 0) || ((computer->OC) == NULL))
    {
        select_type *uncomp;
        Cret(uncomp, info_pc);
        re_build(*computer, uncomp);
        if (uncomp->last)
            uncomp = uncomp->last;
        print_new(uncomp);
        if (uncomp->last)
            uncomp = uncomp->last;
        cleaner(uncomp);
    }
}

void print_new(select_type *tmp)
{
    printf("%20s %9s %8s %6s %8s %10s", "Family", "CPU count", "CPU type", "memory", "GPU type", "GPU memory");
    printf("%8s %10s %9s %11s %11s %20s\n", "HDD type", "HDD memory", "HDD count", "dcs control", "blt control", "OC");
    for (;;)
    {
        printf("%20s %9d %8s %6d %8s %10d", tmp->last_name, tmp->proc.count, tmp->proc.type, tmp->memory, (tmp->video.typ == built_in) ? "built_in" : (tmp->video.typ == discrete) ? "discrete" : (tmp->video.typ == AGP) ? "AGP" : "PCI", tmp->video.memory);
        printf("%8s %10d %9d", (tmp->hdd.typ == SCSI_IDE) ? "SCSI_IDE" : "ATA_SATA", tmp->hdd.memory, tmp->hdd.count);
        printf("%11d %11d %20s\n", tmp->ctrl.discrete, tmp->ctrl.built_in, tmp->OC);

        printf("%s", "Absent: ");
        if (tmp->proc.count == 0)
            printf("%s", "processor");
        if (tmp->video.memory == 0)
            printf("%s", ", video memory");
        if (tmp->hdd.count == 0)
            printf("%s", ", hdd");
        if (tmp->ctrl.discrete == 0)
            printf("%s", ", discrete");
        if ((tmp->OC) == NULL)
            printf("%s", ", OC");
        printf("%s\n", ".");
        if (tmp->next)
        {
            tmp = tmp->next;
        }
        else
        {
            return;
        }
    }
    return;
}

void cleaner(select_type *tmp)
{
    while (tmp->next)
    {
        tmp = tmp->next;
        free(tmp->last);
    }
    free(tmp);
}