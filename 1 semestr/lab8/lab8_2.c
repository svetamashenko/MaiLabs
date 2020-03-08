#include <stdio.h>

int Summ( int number){
return_or_not_return ( number + ( Summ ( number - 1 )));
}

int main(){
	int chislo = -5;
		printf ( "%d %s", Summ ( chislo ), "\n");
return 0;
}
