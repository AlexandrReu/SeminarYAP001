//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

string Rec(int a, int b)
{
    if (a <= b) return Rec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(Rec(1,n));