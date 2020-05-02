
#include <stdio.h>
#include <stdlib.h>

#include "data.h"
#include "function.h"
#include "parse.h"
#include "tree_output.h"
#include "cleaner.h"
//Я(аноним) много где код исправил, вам необходимо все изучить, осознать и больше так не писать,
//про слово #define лучше забыть вообще
int menu(void)
{
    printf("%s\n", "1. Enter expression");
    printf("%s\n", "2. Transform expression");
    printf("%s\n", "3. Text output expression");
    printf("%s\n", "4. Tree output expression");
    printf("%s\n", "5. Exit");
    int ans;
    printf("%s", "Your choise: "); 
    scanf("%d", &ans);
    return ans;
}

int main()//Сделайте более дружелюбную к пользователю менюшку, чтобы она общалась с пользователем
{
    cell *root_tmp = NULL;
    printf("%s\n", "You are welcome!");
    int choise = 0;

    while (choise != 5)
    {
        choise = menu();
        switch (choise)
        {//case со скобками ужасы
        case 1:
            getchar();
            clean_tree(root_tmp);
            root_tmp = parse(root_tmp);
            if (!root_tmp)
            {
                printf("%s\n", "Error!");
                break;//почему после ошибки у вас не выходило из цикла
            }
            while (root_tmp->parent)
                root_tmp = root_tmp->parent;
            printf("\n");
            break;
        case 2:
            getchar();
            func(root_tmp);
            //функиция на примере a / 1 не работает, пофиксите
            printf("\n");
            break;
        case 3:
            getchar();
            //text_out(root_tmp);
            printf("\n");
            break;
        case 4:
            getchar();
            tree_out(root_tmp, 1);
            printf("\n");
            break;
        case 5:
            break;
        default:
            printf("%s\n", "Try again)");
            break;
        }
    }
    printf("%s", "Goodbye!");
    return 0;
}