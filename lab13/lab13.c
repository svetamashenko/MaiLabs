#include <stdio.h>
#include <math.h>

unsigned long long int proofer (unsigned long long int a, long long unsigned int b)
{
    unsigned long long int answer = 100000000000000;
    int k = 0;
    for (int i = 1; i <= 15; i++)
    {
        if (((a % 10) == 1) & ((b % 10) == 1))
        {
            k = 1;
            return 1;
        }
        a = a / 10; b = b / 10;}
        return k;
    }

    unsigned long long int add1(int a)
    {
        unsigned long long int first = 1000000000000000;
        if ((a <= 110) && (a >= 97))
        {
            first = first + pow(10, 111 - a);
        }
        return first;
    }

    unsigned long long int add2(int a)
    {
        unsigned long long int first = 100000000000;
        if ((a <= 122) && (a >= 111))
        {
            first = first + pow(10, 122 - a);
        }
        return first;
    }

int main()
{
    char word;
    int count = 0, trigger = 0, k = 0;
    unsigned long long int letter1 = 1100010001000001, letter2 = 100000100010;
    while (scanf("%c", &word) != EOF)
    {
        if ((trigger == 0) & (word != ' '))
        {
            int premier = word;
            trigger = 1;
            if ((trigger == 1) & (word != ' ')){
            k++;
            for (int i = 1; i < k - 1; i++)
            {
                int last = word;
                if (proofer(premier, last) == 1)
                {
                    count++;
                }
                trigger = 0;
            }}
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