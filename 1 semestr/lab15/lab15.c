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

int diagonal_up(int a, int k, int tab[])
{
int c = 0;
for (int i = 1; i <= (k * k - a) % k + 1; i++)
{
c += tab[a - (k - 1) * (i - 1)];
}

return c;
}

int diagonal_up2(int a, int k, int tab[])
{
int c = 0;
for (int i = 1; i <= a / k + 1; i++)
{
c += tab[a - (k - 1) * (i - 1)];
}

return c;
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

for (int i = 0; i <= rang / 3 ; i++)
{
table[k - i * (rang + 1)] = diagonal_up(rang * rang - 2 * i, rang, table);
}

table[(k-1)/2 +1] = diagonal_up(k - rang + 1, rang, table);

for (int i = 0; i <= rang / 3; i++)
{
table[(k-1)/2 +1 - (i+1) * (rang + 1)] = diagonal_up2(rang * (rang - 3 - 2 * i) + 1, rang, table);
}

}


else {
for (int i = 0; i <= rang / 2 -1; i++)
{
table[k - i * (rang + 1)] = diagonal_up(rang * rang - 2 * i, rang, table);
}

for (int i = 0; i <= rang / 2 -1; i++)
{
table[((k)/2-(rang/2))-i*(rang+1)] = diagonal_up2(k - 2 * rang * (i+1) + 1, rang, table);
}

}

for (int i = 0; i <= rang - 1; i++)
{
for (int y = 1; y <= rang; y++)
{
printf("%3d ", table[i*rang+y]);
}
printf("\n");
}
return 0;
}