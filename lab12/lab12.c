#include <stdio.h>

int main (){
    int n;
    while (scanf ("%d",&n) != EOF){
    printf ("%d %s", ~n, "\n");}
    return 0;
}