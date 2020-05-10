#include <stdio.h>
#include <malloc.h>
#include <strings.h>

int menu(void)
{
    printf("%s\n", "1. Enter strings:");
    printf("%s\n", "2. Sort of simple pastings:");
    printf("%s\n", "3. Double searching:");
    int ans;
    scanf("%d", &ans);
    return ans;
}

int main()
{
    double *table;
    double real;
    char number;

    int s = 0;
    int k = 0;
    while (k != 4)
    {
        k = menu();
        switch (k)
        {
        case 1:
        {
            getchar();
            while ((scanf("%s") != (EOF)))
            {
                scanf("%c\n", &number);
                if (sizeof(number) == 16 * sizeof(char))
                {
                }
                table = (double *)realloc(table, sizeof(table) + sizeof(real));
                table[s] = real;
                s++;
            }
        }
        break;
        case 2:
        {
            getchar();
        }
        break;
        case 3:
        {
            getchar();
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