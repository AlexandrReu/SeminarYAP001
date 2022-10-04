//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Введите количесво вводимых чисел.");
// int size = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Количество чисел больше 0 = {UserNumb(size)}");

// int UserNumb(int size)
// {
//     int count = 0;
//    for(int i = 1; i <= size; i++)
//    {
//     Console.WriteLine($"Введите число №{i}");
//     int numb = int.Parse(Console.ReadLine()!);
//     if(numb > 0)
//     {
//         count++;
//     }
//     }
//    return count;
// } 

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите два значения для первой прямой: ");
double k1 = double.Parse(Console.ReadLine()!);
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите два значения для второй прямой: ");
double k2 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Точка пересечения двух прямых = {FindX(k1, b1, k2, b2)} , {FindY(k1, b1, k2, b2)}");


double FindX(double k1, double b1, double k2, double b2)
{
  double x = (b2 - b1) / (k1 - k2);
  return x;
}
double FindY(double k1, double b1, double k2, double b2)
{
  double y = k1 * (b2 - b1) / (k1 - k2) + b1;
  return y;
}


