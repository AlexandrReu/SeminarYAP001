//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Console.WriteLine("Введите количесво строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количесво столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] matr = FillArray(str, col, -100, 100);
PrintArray(matr);





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


