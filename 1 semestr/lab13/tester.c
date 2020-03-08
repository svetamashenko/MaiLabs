#include <stdio.h>
#include <math.h>

unsigned long long int proofer(unsigned long long int a, long long unsigned int b)
{
    int k = 0;
    for (int i = 1; i <= 13; i++)
    {
        if (((a % 10) == 1) && ((b % 10) == 1))
        {
            k = 1;
        }
        a = a / 10;
        b = b / 10;
    }
    return k;
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
    int count = 0;
    char a, b;
    scanf("%c %c", &a, &b);
    int word1 = a;
    int word2 = b;
    unsigned long long int letter1 = 1100010001000, letter2 = 100100000100010;
    if ((proofer(add1(a), letter1) == 1) || (proofer(add2(a), letter2) == 1))
    {
        if ((proofer(add1(b), letter1) == 1) || (proofer(add2(b), letter2) == 1))
        {
            count++;
        }
    }
    printf("%llu %llu %llu %llu %d", add1(a), add2(b), proofer(add1(word1), letter1), proofer(add2(word2), letter2), count);
    return 1;
}