// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int a)
{
    if(a == 1) return "1";
    else return $"{a} " + PrintNumbers(a - 1);

}

Console.Clear();
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(n));