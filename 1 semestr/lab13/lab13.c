#include <stdio.h>
#include <math.h>

unsigned long long int proofer(unsigned long long int a, long long unsigned int b)
{
    int k = 0;
    for (int i = 1; i <= 12; i++)
    {
        if (((a % 10) == 1) & ((b % 10) == 1))
        {
            return 1;
        }
        a = a / 10;
        b = b / 10;
    }
    return 0;
}

unsigned long long int add1(int a)
{
    unsigned long long int first = 1000000000000;
    if ((a <= 108) && (a >= 97))
    {
        first = first + pow(10, 108 - a);
    }
    return first;
}

unsigned long long int add2(int a)
{
    unsigned long long int first = 100000000000000;
    if ((a <= 122) && (a >= 109))
    {
        first = first + pow(10, 122 - a);
    }
    return first;
}

int main()
{
    char word;
    int count = 0, trigger = 0, k = 0;
    char premier, now, last;
    unsigned long long int letter1 = 1100010001000, letter2 = 100100000100010;
    while (scanf("%c", &word) != EOF)
    {
        if (trigger == 2)
        {

            if ((proofer(add1(premier), letter1) == 1) || (proofer(add2(premier), letter2) == 1))
            {
                if ((proofer(add1(last), letter1) == 1) || (proofer(add2(last), letter2) == 1))
                {
                    count++;
                }
            }
            trigger = 0;
        }

        else if ((trigger == 1) && (word == ' '))
        {
            last = now;
            trigger = 2;
        }

        else if ((trigger == 1) && (word != ' '))
        {
            last = now;
            now = word;
        }

        if ((trigger == 0) && (word == ' '))
        {
            premier = word;
        }
        if ((trigger == 0) && (word != ' '))
        {
            premier = word;
            now = word;
            trigger = 1;
        }
    }

    if (count > 0)
    {
        printf("%s", "yes");
    }
    else
    {
        printf("%s", "no");
    }
    return 0;
}