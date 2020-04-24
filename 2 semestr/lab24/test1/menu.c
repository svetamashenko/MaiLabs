#include <stdio.h>
#include <stdlib.h>
#include "data.h"
#include "./builder/builder.h"
#include "./output/text_output.h"

int menu()
{
    printf("%s\n", "1. Add int.");
    printf("%s\n", "2. Add char.");
    printf("%s\n", "3. Text output.");
    printf("%s\n", "4. Exit.");
    int ans;
    scanf("%d", &ans);
    return ans;
}

int main()
{
    cell *tmp = NULL;
    printf("%s\n", "Welcome!");
    int k = 0;

    while (k != 4)
    {
        k = menu();
        switch (k)
        {
        case 1:
        {
            getchar();
            int value;
            printf("%s", "Enter a char: ");
            scanf("%d", &value);
            int val = value;
            tmp = add_int(val, tmp);
            printf("\n");
        }
        break;
        case 2:
        {
            char sign;
            getchar();
            printf("%s", "Enter a char: ");
            scanf("%c", &sign);
            tmp = add_char(sign, tmp);
            printf("\n");
        }

        break;
        case 3:
        {
            while ((tmp->parent) != NULL)
                tmp = tmp->parent;
            text_out(tmp, 0);
        }
        break;
        case 4:
        {
            break;
        }
        default:
            printf("%s\n\n", "Try again.");
            break;
        }
    }

    printf("%s\n", "Goodbye!");
    return 0;
}
