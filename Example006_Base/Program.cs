﻿//Учимся решать задачи с гирями.
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if(b > max) max = b;
if(d > max) max = d;
if(c > max) max = c;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);