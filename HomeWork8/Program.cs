//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Введите количесво строк: ");
// int str = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количесво столбцов: ");
// int col = int.Parse(Console.ReadLine()!);
// int[,] matr = FillArray(str, col, 0, 100);
// PrintArray(matr);
// Console.WriteLine();
// StreamlineString(matr);
// PrintArray(matr);

// void StreamlineString(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(1) - 1; k++)
//         {
//             if (array[i, k] < array[i, k + 1])
//             {
//                 int temp = array[i, k + 1];
//                 array[i, k + 1] = array[i, k];
//                 array[i, k] = temp;
//             }
//         }
//     }
//   }
// }  

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matr = FillArray(5, 5, 0, 100);
PrintArray(matr);
int minSumIndex = 0;
int sumOfString = GetSumOfString(matr, 0);

for(int i = 1; i < matr.GetLength(0); i++)
{
    int tempSumOfString = GetSumOfString(matr, i);
    if(sumOfString > tempSumOfString)
    {
        sumOfString = tempSumOfString;
        minSumIndex = i;
        Console.WriteLine($"Наименьшая сумма элементов = {sumOfString}.");
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов = {minSumIndex + 1}.");


int GetSumOfString(int[,] array, int i)
{
    int tempSumOfString = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSumOfString += array[i, j];
    }
    return tempSumOfString;
}



int[,] FillArray(int str, int col, int minValue, int maxValue)
{
    int[,] array = new int[str, col];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}