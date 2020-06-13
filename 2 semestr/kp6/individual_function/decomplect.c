#include <stdio.h>
#include "decomplect.h"
#include "../re_builder/re_builder.h"
#include "../data.h"
#include <malloc.h>

void function(select_type *computer)
{
    while (computer->last)
    {
        printf("%s\n", computer->last_name);
        computer = computer->last;
    }
    while (computer->next)
    {
        if ((computer->proc.count == 0) || (computer->video.memory == 0) || (computer->hdd.count == 0) || (computer->ctrl.discrete == 0) || ((computer->OC) == 0))
        {
            printf("%d\n", 1);
            print_new(computer);
        }
        computer = computer->next;
    }
    if ((computer->proc.count == 0) || (computer->video.memory == 0) || (computer->hdd.count == 0) || (computer->ctrl.discrete == 0) || ((computer->OC) == 0))
    {
        printf("%d\n", 1);
        print_new(computer);
    }
}

void print_new(select_type *tmp)
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
}