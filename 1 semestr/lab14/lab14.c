#include <stdio.h>

int rank(int a)
{
    int k = 0;
    for (int i = 0; i < 8; i++)
    {
        if (a - (k + 1 + 2 * i) == 0)
        {
            return i + 1;
        }
        k += 1 + 2 * i;
    }
}

void diagonal_up(int a, int k, int tab[])
{
    int c;
    for (int i = 1; i <= (k * k - a) % k + 1; i++)
    {
        printf("%d ", tab[a - (k - 1) * (i - 1)]);
    }
}

void diagonal_down(int a, int k, int tab[])
{
    int c;
    for (int i = 1; i <= (k * k - a) / k + 1; i++)
    {
        printf("%d ", tab[a + (k - 1) * (i - 1)]);
    }
}

void diagonal_up2(int a, int k, int tab[])
{
    int c;
    for (int i = 1; i <= a / k + 1; i++)
    {
        printf("%d ", tab[a - (k - 1) * (i - 1)]);
    }
}

void diagonal_down2(int a, int k, int tab[])
{
    int c;
    for (int i = 1; i <= a; i++)
    {
        printf("%d ", tab[a + (k - 1) * (i - 1)]);
    }
}

int main()
{

    int value, rang, var, k = 0;
    int table[65];
    while (scanf("%d", &value) != EOF)
    {
        table[k + 1] = value;
        k += 1;
    }
    rang = rank(k);
    if (rang % 2 == 1)
    {
        for (int i = 0; i <= rang / 4; i++)
        {
            diagonal_up(rang * rang - 2 * i, rang, table);
            diagonal_down(rang * (rang - 2 * i - 1), rang, table);
        }
        diagonal_up(k - rang + 1, rang, table);
        for (int i = 0; i <= rang / 4; i++)
        {
            diagonal_down2(rang - 1 - 2 * i, rang, table);
            diagonal_up2(rang * rang - 3 * rang + 1 - 2 * i * rang, rang, table);
        }
    }

    else
    {
        for (int i = 0; i <= rang / 4; i++)
        {
            diagonal_up(rang * rang - 2 * i, rang, table);
            diagonal_down(rang * (rang - 2 * i - 1), rang, table);
        }
        for (int i = 0; i <= rang / 4 - 1; i++)
        {
            diagonal_up2(rang * (rang - 2 * (i + 1)) + 1, rang, table);
            diagonal_down2(rang - 2 * (i + 1), rang, table);
        }
        printf("%d", table[1]);
    }

    return 0;
}