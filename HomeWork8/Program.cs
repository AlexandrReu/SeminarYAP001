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

// int[,] matr = FillArray(5, 5, 0, 100);
// PrintArray(matr);
// int minSumIndex = 0;
// int sumOfString = GetSumOfString(matr, 0);

// for(int i = 1; i < matr.GetLength(0); i++)
// {
//     int tempSumOfString = GetSumOfString(matr, i);
//     if(sumOfString > tempSumOfString)
//     {
//         sumOfString = tempSumOfString;
//         minSumIndex = i;
//         Console.WriteLine($"Наименьшая сумма элементов = {sumOfString}.");
//     }
// }
// Console.WriteLine($"Строка с наименьшей суммой элементов = {minSumIndex + 1}.");
// int GetSumOfString(int[,] array, int i)
// {
//     int tempSumOfString = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         tempSumOfString += array[i, j];
//     }
//     return tempSumOfString;
// }

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] matrOne = FillArray(3, 3, 1, 10);
int[,] matrTwo = FillArray(3, 3, 1, 10);
int[,] matrRes = new int[3, 3];
Multiplication(matrOne, matrTwo, matrRes);
Console.WriteLine("Первая матрица: ");
PrintArray(matrOne);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrTwo);
Console.WriteLine("Произведение вдух матриц: ");
PrintArray(matrRes);

void Multiplication(int[,] matrOne, int[,] matrTwo, int[,] matrRes)
{
  for (int i = 0; i < matrRes.GetLength(0); i++)
  {
    for (int j = 0; j < matrRes.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrOne.GetLength(1); k++)
      {
        sum += matrOne[i,k] * matrTwo[k,j];
      }
      matrRes[i,j] = sum;
    }
  }
}



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Задача не решена((
// int[,,] matrix3D = FillArray3D(4, 4, 4, 10, 100);
// PrintArray3D(matrix3D);


// int[,,] FillArray3D(int str, int col, int depth, int minValue, int maxValue)
// {
//     int howManyNumb = str*col*depth;
//     Random rnd = new Random();
//     int[,,] array = new int[str, col, depth];
//     for (int i = 0; i < str; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//             int[] numb = Enumerable.Range(minValue, maxValue + 1).OrderBy(y => rnd.Next()).Take(howManyNumb).ToArray();
//             array[i, j, k] = numb[k];
//             foreach (var c in array);
//             }
//         }
//     }
//     return array;
// }

// void PrintArray3D(int[,,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for(int k = 0; k < matr.GetLength(2); k++)
//             {
//             Console.Write($"{matr[i, j, k]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

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


