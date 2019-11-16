#include <stdio.h>

int Summ(int number){
	return(number==0)?0:(number==1)?1:(number+(Summ(number-1)));
}

int main(){
	int chislo;
	while(scanf("%d", &chislo)!=EOF){
		printf("%d %s", Summ(chislo), "\n");
}

return 0;
}
