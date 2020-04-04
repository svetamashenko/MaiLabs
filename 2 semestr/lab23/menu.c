#include <time.h>
#include <stdio.h>
#include <stdlib.h>

#include "data.h"
#include "add_delete.h"
#include "text_output.h"
#include "range.h"

int menu()
{
    printf("%s\n", "1. Add cell.");
    printf("%s\n", "2. Delete cell.");
    printf("%s\n", "3. Text output.");
    printf("%s\n", "4. Check range.");
    printf("%s\n", "5. Random filling.");
    printf("%s\n", "6. Exit.");
    int ans;
    scanf("%d", &ans);
    return ans;
}

int main()
{
    cell root = {NULL, NULL, -100};
    cell *root_tmp = &root;
    printf("%s\n", "Welcome!");
    int k = 0;
    while (k != 6)
    {
        k = menu();
        switch (k)
        {
        case 1:
        {
            char value;
            getchar();
            printf("%s", "Enter a char: ");
            scanf("%c", &value);
            int val = value;
            add(root_tmp, val);
            printf("%c", value);
            printf("\n");
        }
        break;
        case 2:
        {
            char value;
            getchar();
            printf("%s", "Enter a char: ");
            scanf("%c", &value);
            int val = value;
            delete (root_tmp, val);
            printf("%c", value);
            printf("\n");
        }
        break;
        case 3:
            text_out(root_tmp, 0);
            break;
        case 4:
        {
            char value1, value2;
            getchar();
            printf("%s ", "Enter a char`s:");
            scanf("%c %c", &value1, &value2);
            int val1 = value1;
            int val2 = value2;
            range(root_tmp, val1, val2);
            printf("\n");
        }
        break;
        case 5:
        {
            int i, r;
            srand(time(NULL));
            for (i = 0; i < 20; i++)
            {
                add(root_tmp, (rand() % 95 + 32));
            }
        }
        break;
        case 6:
            //exit
            break;
        default:
            printf("%s\n\n", "Try again.");
            break;
        }
    }

    printf("%s\n", "Goodbye!");
    return 0;
}
