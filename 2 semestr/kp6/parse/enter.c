#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include "../data.h"
#include "../writer/writer.h"
#include "../re_builder/re_builder.h"

void fill_pc()
{
  str(tmp_type);
  int choice = 0;
  info_pc *tmp = NULL;
  while (choice != 2)
  {
    printf("%s\n", "Choose your option");
    printf("%s\n", "1) Add");
    printf("%s\n", "2) Exit");
    scanf("%d", &choice);
    if (choice == 1)
    {
      char sex;
      char offsets;
      if (!tmp)
      {
        Cret(tmp, info_pc);
        tmp->next = NULL;
        tmp->last = NULL;
      }
      else
      {
        Cret(tmp->next, info_pc);
        tmp->next->last = tmp;
        tmp = tmp->next;
        tmp->next = NULL;
      }
      printf("%s\n", "Please enter:");
      printf("%s", "Last name - ");
      scanf("%s", &tmp->last_name);
      printf("%s", "Number of processors - ");
      scanf("%d", &tmp->proc.count);
      printf("%s", "Type of processors - ");
      scanf("%20s", &tmp->proc.type);
      printf("%s", "Memory - ");
      scanf("%d", &tmp->memory);
      printf("%s", "GPU type(built_in(b)/discrete(d)/AGP(a)/PCI(p)) - ");
      scanf("%s", &tmp_type);
      tmp->video.typ = (*tmp_type == 'b') ? built_in : (*tmp_type == 'd') ? discrete : (*tmp_type == 'a') ? AGP : PCI;
      printf("%s", "Video card memory(GB) - ");
      scanf("%3d", &tmp->video.memory);
      printf("%s", "HDD type(SCSI(s)/ATA(a)) - ");
      scanf("%s", &tmp_type);
      tmp->hdd.typ = (*tmp_type == 's') ? SCSI_IDE : ATA_SATA;
      printf("%s", "Winchester memory(GB) - ");
      scanf("%d", &tmp->hdd.memory);
      printf("%s", "Number of winchester - ");
      scanf("%d", &tmp->hdd.count);
      printf("%s", "Number of controller - ");
      scanf("%d", &tmp->ctrl.built_in);
      printf("%s", "Number of external devices - ");
      scanf("%d", &tmp->ctrl.discrete);
      printf("%s", "Operating system - ");
      scanf("%20s", &tmp->OC);
    }
    else if (choice != 2)
    {
      printf("%s", "Try again");
    }
    else
    {
      to_high(tmp);
      printf("%s\n", "Goodbye");
    }
  }
}

int main()
{
  printf("%s\n", "Welcome!");
  select_type form;
  _Generic((form),/*
           info_stud
           : fill_student() ,
             info_exam
           : fill_exam(),
             info_passenger
           : fill_passenger(),*/
             info_pc
           : fill_pc()/*,
             info_school
           : fill_school()*/
  );

  return 0;
}