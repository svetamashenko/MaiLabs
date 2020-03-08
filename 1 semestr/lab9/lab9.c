#include <stdio.h>

int min (int a, int b){
	return (a < b) ? a : b;
}

int max (int a, int b){
	return (a > b) ? a : b;
}

int mod (int a, int b){
	return (a < 0) ? (-a % b) : (a % b);
}

int modul (int a){
	return (a >= 0) ? a : (-a);
}

int main (){

	//int i, j, l, k;
	//while(scanf("%d %d %d", &i, &j, &l) !=EOF){
	int i = 11, j = 13, l = 10, k, a;
	for (k = 1; k <= 50; k++){
		i = modul(k - 15) - min(j/3, (mod((j+l), 10))) - 20;
		j = -(j + k)/5 + modul(mod((j*l), 8));
		l = max(mod((i + j), 15), mod((l + k), 14));
		if ((5 < i < 15) && (-15 < j < -5)) {
			printf ("%s %d", "Попадание совершено, время ", k);
			return 0;
		}
	}

	printf ("%s %d %s %d %s %d %s %d", "Попадание не совершено, время окончания движения ", k - 1, ", конечные координаты точки (", i, ", ", j, "), динамический параметр движения ", l);
	return 0;
}

