#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include "data.h"
#include "push_pop/push_pop.h"
#include "output/output.h"
#include "sort/sort.h"
#include "concatenation/concatenation.h"

int menu(void)
{
    printf("%s\n", "1. Push: stack 1");
    printf("%s\n", "2. Push: stack 2");
    printf("%s\n", "3. Pop: stack 1");
    printf("%s\n", "4. Pop: stack 2");
    printf("%s\n", "5. Text output: stack 1");
    printf("%s\n", "6. Text output: stack 2");
    printf("%s\n", "7. Sort: stack 1");
    printf("%s\n", "8. Sort: stack 2");
    printf("%s\n", "9. Concatenation");
    int ans;
    scanf("%d", &ans);
    return ans;
}

int main()
{
    int first = 0;
    int count1 = 0;
    int count2 = 0;
    int *stack1, *stack2;
    stack1 = (int *)malloc(sizeof(int));
    stack2 = (int *)malloc(sizeof(int));
    printf("%s\n", "Welcome!");
    int k = 0;
    while (k != 10)
    {
        k = menu();
        switch (k)
        {
        case 1:
        {
            getchar();
            int add;
            scanf("%d", &add);
            *stack1 = *push(add, stack1, count1);
            printf("\n");
            count1++;
        }
        break;
        case 2:
        {
            getchar();
            int add;
            scanf("%d", &add);
            *stack2 = *push(add, stack2, count2);
            printf("\n");
            count2++;
        }
        break;
        case 3:
        {
            getchar();
            pop(stack1, count1);
            printf("\n");
            count1--;
        }
        break;
        case 4:
        {
            getchar();
            pop(stack1, count2);
            printf("\n");
            count2--;
        }
        break;
        case 5:
        {
            getchar();
            output(stack1, count1);
            printf("\n");
        }
        break;
        case 6:
        {
            getchar();
            output(stack2, count2);
            printf("\n");
        }
        break;
        case 7:
        {
            getchar();
            count1--;
            sort(stack1, first, count1);
            count1++;
            printf("\n");
        }
        break;
        case 8:
        {
            getchar();
            count2--;
            sort(stack2, first, count2);
            count2++;
        }
        break;
        case 9:
        {
            getchar();
            stack1 = concatenation(stack1, count1, stack2, count2);
            count1 = count1 + count2;
            count2 = 0;
            free(stack2);
            printf("\n");
        }
        case 10:
            break;
        default:
            printf("%s\n", "Try again)");
            break;
        }
    }
    printf("%s", "Goodbye!");
    return 0;
}