//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Console.WriteLine("Введите количесво строк: ");
// int str = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количесво столбцов: ");
// int col = int.Parse(Console.ReadLine()!);

// int[,] matr = FillArray(str, col, -100, 100);
// PrintArray(matr);

// void PrintArray(int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int str = new Random().Next(3,7);
// int col = new Random().Next(3,7);
// int[,] matr = FillArray(str, col, -100, 100);
// PrintArray(matr);
// Console.WriteLine("Введите номер строки искомого элемента: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите номер колонки искомого элемента: ");
// int columns = int.Parse(Console.ReadLine()!);

// PrintTask50(matr);

// void PrintTask50(int[,] matr)
// {
//     if(rows >= matr.GetLength(0) || columns >= matr.GetLength(1))
//     {
//         Console.WriteLine("Элемента с таким индексом нет.");
//     }
//     else
//     {
//         for(int i = 0; i < matr.GetLength(0); i++)
//         {
//             for(int j = 0; j < matr.GetLength(1); j++)
//             {
//                 if((rows == i) && (columns == j))
//                 {
//                     Console.WriteLine($"Искомый элемент = {matr[i,j]} ");
//                 }
//             }
//         }
//     }
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количесво строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количесво столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] matr = FillArray(str, col, 0, 100);
PrintArray(matr);
PrintTask52(matr);

void PrintTask52(int[,] matr)
{
    double sum = 0;
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;
        for(int i = 0; i < str; i++)
        {
            sum += matr[i, j];
        }
    sum = sum/matr.GetLength(0);
    Console.WriteLine($"Среднее арифметическое элементов в столбце {j + 1} = {sum:f1}");
    }
}





int[,] FillArray(int str, int col, int minValue, int maxValue)
{
    int[,] array = new int[str,col];
    for(int i = 0; i < str; i++)
    {
        for(int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}