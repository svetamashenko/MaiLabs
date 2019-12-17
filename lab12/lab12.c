#include <stdio.h> 
#include <math.h>

int dvoich (int a){
    int translation = 0, dv;
    if (a < 0) {
        a = -a;}
        else {a++;}
        for (int i=1; i < 9; i++) {    
        dv = pow (2, (double) (8 - i));
       if (((dv - a) < dv) && (a > dv)){
        translation = translation*10 + 1;
        a = a - dv;}
        else if (a != 0) {
            translation = translation*10;
        }}
    return (translation);}

int main (){
    int number, answer;
    while (scanf ("%d", &number) != EOF){
    answer = dvoich(number);
    if (number >= 0) {printf ("%08d\n", answer);}
    else {printf ("%08d\n", 11111111 - answer);}}
    return 0;
}