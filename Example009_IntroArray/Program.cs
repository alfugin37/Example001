﻿// Изучаем метод массивов.
// Функции-начало.
/* 
int  a1 = 15;
int  b1 = 21;
int  c1 = 39;
int  a2 = 12;
int  b2 = 2311;
int  c2 = 33;
int  a3 = 13;
int  b3 = 23;
int  c3 = 313;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/

int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if(arg2 > resalt) resalt = arg2;
    if(arg3 > resalt) resalt = arg3;
    return resalt;
}
 //             0   1   2   3   4   5   6   7   8
int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};

/*array[0] = 12;
Console.WriteLine(array[4]);
*/
 
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);

