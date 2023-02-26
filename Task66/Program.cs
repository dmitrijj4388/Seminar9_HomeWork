﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int a, int b)
{
    if(a == b) return a;
    else return a = a + SumNumbers(a + 1,b);
}

Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int result = SumNumbers(m,n);
Console.WriteLine(result);
