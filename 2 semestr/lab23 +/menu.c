#include <time.h>
#include <stdio.h>
#include <stdlib.h>

#include "data.h"
#include "./add_delete/add_delete.h"
#include "./output/text_output.h"
#include "./function/range.h"

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
    cell *root_tmp = NULL;
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
            if (!root_tmp)
            {
                root_tmp = create(val);
            }
            else
            {
                add(root_tmp, val);
            }
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
            if (root_tmp)
            {
                if (!root_tmp->left && !root_tmp->right && val == root_tmp->value)
                {
                    root_tmp = destroy(root_tmp);
                }
                else
                {
                    if (!root_tmp->left && !root_tmp->right && val != root_tmp->value)
                    {
                        printf("%s\n", "This char isn`t exist");
                    }
                    else
                    {
                        delete (root_tmp, root_tmp, val);
                    }
                }
                //delete (root_tmp, root_tmp, val);
            }
            else
            {
                printf("%s\n", "Tree is empty");
            }
            printf("\n");
        }
        break;
        case 3:
        {
            getchar();
            text_out(root_tmp, 0);
        }
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
            srand(time(NULL));
            if (!root_tmp)
            {
                root_tmp = create((rand() % 95 + 32));
            }
            for (int i = 0; i < 10; i++)
            {
                add(root_tmp, (rand() % 95 + 32));
            }
        }
        break;
        default:
            printf("%s\n\n", "Try again.");
            break;
        }
    }

    printf("%s\n", "Goodbye!");
    return 0;
}
