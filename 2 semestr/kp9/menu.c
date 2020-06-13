#include <stdio.h>
#include <malloc.h>
#include <stdlib.h>
#include "data.h"

int menu(void)
{
    printf("%s\n", "1. Add in the table.");
    printf("%s\n", "2. Sort table.");
    printf("%s\n", "3. Search int the table.");
    printf("%s\n", "4. Exit.");
    int ans;
    scanf("%d", &ans);
    return ans;
}

int main()
{
    row *table = NULL;
    int size = 0;

    printf("%s\n", "Welcome!");
    int k = 0;

    while (k != 4)
    {
        k = menu();
        switch (k)
        {
        case 1:
        {
            char strings[100];
            float code;
            FILE *file = fopen("test2.txt", "r");
            while (fscanf(file, "%[^\n]s%s%f", &strings, &code) != EOF)
            {
                size += 1;
                table = (row *)realloc(table, size * sizeof(row));
                if (!table)
                {
                    size -= 1;
                    printf("Out of memory\n");
                    break;
                }
                for (int i = 0; i < 100; i++)
                    table[size - 1].string[i] = strings[i];
                (table[size - 1].key) = code;
            }
        }
        break;
        case 2:
        {
            for (int i = 0; i < size; i++)
            {
                printf("%7f  %s\n", table[i].key, table[i].string);
            }
            printf("\n");

            for (int i = 1; i < size; i++)
            {
                int k = i;
                while (k > 0 && table[k].key < table[k - 1].key)
                {
                    row f = table[k];
                    table[k] = table[k - 1];
                    table[k - 1] = f;
                    k -= 1;
                }
            }

            for (int i = 0; i < size; i++)
            {
                printf("%7f  %s\n", table[i].key, table[i].string);
            }
            printf("\n");
        }
        break;
        case 3:
        {
            getchar();
            printf("Enter a key: ");
            float key;
            scanf("%f", &key);
            search(table, 0, size - 1, key);
        }
        break;
        case 4:
            break;
        default:
            printf("%s\n", "Try again)");
            break;
        }
    }

    printf("%s", "Goodbye!");
    return 0;
}