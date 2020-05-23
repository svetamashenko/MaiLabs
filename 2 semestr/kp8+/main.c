/*
 * Создание линейного двунапрвленного списка, 
 * проведение над ним 4 стандартных действий и 1 нестандартного.
 * Стандартные:
 * 1. Печать списка
 * 2. Вставка нового элемента в список
 * 3. Удаление элемента из списка
 * 4. Подсчёт длины списка
 * Тип элементов: перечислимый
 * Нестандартное действие: дополнение списка копиями некоторого значения до указанной длины
 */
#include "data.h"

int menu(void)
{
    printf("%s\n", "1. Print");
    printf("%s\n", "2. Insert");
    printf("%s\n", "3. Delete");
    printf("%s\n", "4. Size");
    printf("%s\n", "5. Unstd_act");
    printf("%s\n", "6. Exit");
    int ans;
    scanf("%d", &ans);
    return ans;
}

int main()
{

    printf("%s\n", "Gather your team of heroes!");
    int k = 0;
    struct cell *barrier = NULL;
    while (k != 6)
    {
        k = menu();
        switch (k)
        {
        case 1: //Print
        {
            getchar();
            std_print(barrier);
        }
        break;
        case 2: //Insert
        {
            getchar();
            printf("Choose a new hero(\nwizard(1)\ncelstial(2)\ngroovein(3)\nblademaster(4)\nvalkyrie(5)): ");
            int value;
            scanf("%d", &value);
            if (value > 5 || value < 1)
            {
                printf("Stay firm in your faith and try again!\n");
            }
            else
            {
                barrier = std_insert(barrier, (value==1)?wizard:(value==2)?celstial:(value==3)?groovein:(value==4)?blademaster:valkyrie);
            }
        }
        break;
        case 3: //Delete
        {
            getchar();
            printf("Choose the unwanted hero(\nwizard(1)\ncelstial(2)\ngroovein(3)\nblademaster(4)\nvalkyrie(5)): ");
            int value;
            scanf("%d", &value);
            if (value > 5 || value < 1)
            {
                printf("Stay firm in your faith and try again!\n");
            }
            else
            {
                barrier = std_delete(barrier, (value==1)?wizard:(value==2)?celstial:(value==3)?groovein:(value==4)?blademaster:valkyrie);
            }
        }
        break;
        case 4: //Size
        {
            getchar();
            int size;
            size = std_size(barrier);
            if(size==0){
                printf("The team is empty\n");
            }else{
                 printf("The size of team: %d\n", size);
            }
        }
        break;
        case 5: //Unstd_act
        {
            getchar();
            printf("Choose new category of heroes(\nwizard(1)\ncelstial(2)\ngroovein(3)\nblademaster(4)\nvalkyrie(5)) and it's number:\n");
            int value,range;
            scanf("%d %d", &value, &range);
            if (value > 5 || value < 1)
            {
                printf("Stay firm in your faith and try again!\n");
            }
            else
            {
                barrier = unstd_act(barrier, (value==1)?wizard:(value==2)?celstial:(value==3)?groovein:(value==4)?blademaster:valkyrie,range);
            }
        }
        break;
        default:
            printf("%s\n", "Spirits advise you to try again...");
            break;
        case 6:
            break;
        }
    }

    printf("%s", "You has become ledgendary!");
    return 0;
}