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
        int k = 0;
        char a, b;
        scanf ("%c%c", &a, &b);
        int word1 = a; int word2 = b;
        unsigned long long int letter1 = 1100010001000001, letter2 = 100000100010;
        if ((proofer(add1(word1), letter1) == 1) || (proofer(add2(word1), letter2) == 1))
        {
            k = k + 50;
        }
        if ((proofer(add1(word2), letter1) == 1) || (proofer(add2(word2), letter2) == 1))
        {
            k = k + 100;
        }
        printf("%llu %llu %llu %llu %d",add1(a), add2(b), proofer(add1(word1), letter1), proofer(add2(word2), letter2), k);
        return 1;
    }