#ifndef DATA_H
#define DATA_H
#include <stdio.h>
#include <stdlib.h>
//#include <conio.h>
#include <malloc.h>
#define str(a) char a[20];
#define __NAME__ "database"

#define Cret(tmp, type)                 \
    tmp = (type *)malloc(sizeof(type)); \
    if (!tmp)                           \
    {                                   \
        printf("%s\n", "Out of meme");  \
        return;                         \
    }

#define to_high(tmp)         \
    if (tmp)                 \
    {                        \
        while (tmp->last)    \
        {                    \
            tmp = tmp->last; \
        }                    \
        writer(tmp);         \
    }


#define info_pc struct info_pc
#define CPU struct CPU
#define GPU struct GPU
#define HDD struct HDD
#define control struct control

typedef info_pc
{
    str(last_name); //имя
    CPU             //процессор
    {
        int count;
        str(type);
    }
    proc;
    int memory; //память
    GPU         //видяха
    {
        enum type_gpu
        {
            built_in,
            discrete,
            AGP,
            PCI
        } typ;
        int memory;
    }
    video;
    HDD //винчестер
    {
        enum type_hdd
        {
            SCSI_IDE,
            ATA_SATA
        } typ;
        int memory;
        int count;
    }
    hdd;
    control
    { // контроллеры
        int discrete;
        int built_in;
    }
    ctrl;
    str(OC);
    info_pc *next;
    info_pc *last;
}
pc;

#define select_type info_pc

#endif