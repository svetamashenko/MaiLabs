#include <stdio.h> 
#include <stdlib.h>

long int addition (long int a){
    return a;
}

long int dvoich (long int a){
    long int translation = 0;
    if (a < 0) { 
        translation = translation + 10^8; 
        a = -a - 1;
        }
    for (int i=0; i < 8; i++) {
       if (a / (2^(abs (i-7))) == 1 ){
        translation = translation + (10^(abs (i-7)));
        a = a % (2^(abs (i-7)));}
        }
    return (translation);
    }

/*long dvoich (int a){
    int arr[7] = {0}; long translation = 0;
    if (a < 0) { 
        arr[1] = 1; 
        a = -a - 1;
        }
    for (int i=0; i < 7; i++) {
       if (a % (2^(abs (i-7))) <= (2^(abs (i-7)))){
        arr[abs (i-7)] = 1;
        a = a % (2^(abs (i-7)));}
        }
    for (int i=1; i <= 8; i++){
        translation = translation + 10^(9-i) * arr[9-i];
    }
    return (translation);
}*/

/*long dvoich (int a){
    int translation = 0;
    if (a < 0) {

    }

    translation = translation + 10^(9-i) * arr[9-i];
    }
    return (translation);
}*/


int main (){
    long int number;
    while (scanf ("%d", number) != EOF){
    printf ("%d", addition(dvoich(number)));}
    return 0;
}