#include <stdio.h>
#include <stdlib.h>
#include "data.h"
#include "build.h"
#include "cleaner.h"      
    
//уберите ужасные #define везде, код невозможно читать
#define add_int                 \
    tmp = add_int(number, tmp); \
    printf("%d ", number);

//уберите ужасные #define везде, код невозможно читать
#define parse_num(a)                              \
    number = symbol - 48;                         \
    while (scanf("%c", &symbol) != EOF)           \
    {                                             \
        symbol = symbol;                          \
        pos++;                                    \
        if ((symbol >= '0') && (symbol <= '9'))   \
        {                                         \
            number = number * 10 + (symbol - 48); \
        }                                         \
        else if (symbol == ' ' || symbol == '\n') \
        {                                         \
            break;                                \
        }                                         \
        else                                      \
        {                                         \
            printf("%s %d %s\n", "Syntax error in", pos, "position"); \
            clean_tree(tmp);                                          \
            return NULL;                          \
        }                                         \
    }                                             \
    if (!corruption)                              \
    {                                             \
        number *= a;                              \
        add_int;                                  \
        number = 0;                               \
    }
    

cell *parse(cell *tmp)
{
    char symbol;
    int number = 0, corruption = 0, pos = 0;
    while (scanf("%c", &symbol) != '\n')
    {
        pos++;
        if ((symbol >= '0') && (symbol <= '9'))
        {
            parse_num(1);
        } //Вместо кодов из ASCII используйсте символы
        else if (((symbol >= '(') && (symbol <= '+')) || (symbol == '/') ||
                (symbol == '^') || ((symbol >= 'a') && (symbol <= 'z')))
        {
            tmp = add_char((int)symbol, tmp);   
            printf("%c ", symbol);
        }
        else if (symbol == '-')
        {
            scanf("%c", &symbol);
            symbol = symbol;
            pos++;
            if (symbol == ' ')
            {
                symbol = '-';
                tmp = add_char((int)symbol, tmp);   
                printf("%c ", symbol);
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                parse_num(-1);
            }
            else if ((symbol >= 'a') && (symbol <= 'z'))
            {
                symbol = toupper((int)symbol);
                tmp = add_char((int)symbol, tmp);  
                printf("%c ", symbol);
            }
            else
            {
               printf("%s %d %s\n", "Syntax error in", pos, "position"); \
               clean_tree(tmp);                                          \
               return NULL; 
            }
        }
        else if (symbol == ' ')
        {
            continue;
        }
        else if (symbol == '\n')
        {
            pos--;
            return tmp;
        }
        else
        {
            printf("%s %d %s\n", "Syntax error in", pos, "position"); \
            clean_tree(tmp);                                          \
            return NULL;     
        }
        if (corruption)
        {
            return NULL;
        }
    }
    return NULL;// до сюда прога никогда не доходит вообще, но у вас тут код был
}