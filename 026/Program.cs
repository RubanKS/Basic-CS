﻿// Найти сумму чисел от 1 до А

Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

double sum = (N*(N+1))/2;

Console.Write($"{sum}");

/*
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int a = 1;
double sum = 0;

while (a <= N)
{
    sum = sum + a;
    a++;
}

Console.Write($"{sum}");
*/