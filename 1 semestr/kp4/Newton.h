#ifndef NEWTON_H
#define NEWTON_H

#include<stdio.h>
#include<math.h>

#define eps = 0.000001

double my_abs2(double x){
    return ( x >= 0 ) ? x : -x;
}

double Newton(double func(), double proizv(), double a, double b){
    double x = (a + b) / 2;
    while( my_abs2(func(x) / proizv(x)) > eps){
        x = x - (func(x) / proizv(x));
 }
return x;
}

#endif