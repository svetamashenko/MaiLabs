#include <stdio.h>
#include "../data.h"
#define EMPT(a)                            \
    if (!a)                                \
    {                                      \
        printf("%s", "Database is empty"); \
        return;                            \
    }

void output_pc(info_pc *tmp) // info_pc
{
    EMPT(tmp);
    printf("%20s %9s %8s %6s %8s %10s", "Family", "CPU count", "CPU type","memory" "GPU type", "GPU memory");
    printf("%8s %10s %9s %11s %11s %20s\n", "HDD type", "HDD memory", "HDD count", "dcs control", "blt control", "OC");
    for (;;)
    {
        printf("%20s %9d %8s %6d %8s %10d", tmp->last_name, tmp->proc.count, tmp->proc.type, tmp->memory, (tmp->video.typ == built_in)?"built_in":(tmp->video.typ == discrete)?"discrete":(tmp->video.typ == AGP)?"AGP":"PCI",tmp->video.memory);
        printf("%8s %10d %9d", (tmp->hdd.typ == SCSI_IDE)?"SCSI_IDE":"ATA_SATA", tmp->hdd.memory, tmp->hdd.count);
        printf("%11d %11d %20s\n", tmp->ctrl.discrete, tmp->ctrl.built_in, tmp->OC);
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