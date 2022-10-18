//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// string Rec(int a, int b)
// {
//     if (a <= b) return Rec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }
// Console.WriteLine(Rec(1,n));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// int GetSumRec(int m, int n)
// {    
//     if (n == m) return m;
//     else return n + GetSumRec(m, n - 1);    
// }
// Console.WriteLine(GetSumRec(m, n));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int FuncAkk(int m, int n)
{
    if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return FuncAkk(m - 1, 1);
    else
      return FuncAkk(m - 1, FuncAkk(m, n - 1));
}
Console.WriteLine(FuncAkk(m, n));