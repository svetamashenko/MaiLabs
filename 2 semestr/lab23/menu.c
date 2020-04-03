#include <stdio.h>
#include "data.h"
#include "add_delete.h"

int menu()
{
    printf("%s\n", "1. Add cell.");
    printf("%s\n", "2. Delete cell.");
    printf("%s\n", "3. Text output.");
    printf("%s\n", "4. Check diapazon.");
    printf("%s\n", "5. Exit.");
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
    while (k != 5)
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
            break;
        }
        case 3:
            //text_output
            break;
        case 4:
            //function
            break;
        case 5:
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
