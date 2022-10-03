//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = GetArray(23, 100, 1000);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Количество чётных чисел в массиве = {GetCount(array)}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] arr = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//        arr[i] = new Random().Next(minValue, maxValue);
//     }
//     return arr;
// }

// int GetCount(int[] arr)
// {
//     int count = 0;
//     for(int j = 0; j < array.Length; j++)
//     {
//         if(array[j]%2 == 0)
//         {
//            count++;
//         }
//     }
//     return count;
// }


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array2 = GetArray(10, -100, 100);
// Console.WriteLine($"[{String.Join(", ", array2)}]");
// Console.WriteLine($"Сумма чисел на нечётных позициях в массиве = {GetSum(array2)}");


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] arr = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//        arr[i] = new Random().Next(minValue, maxValue);
//     }
//     return arr;
// }

// int GetSum(int[] arr)
// {
//     int sum = 0;
//     for(int j = 0; j < arr.Length; j++)
//     {
//         if(j%2 != 0)
//         {
//             sum += arr[j];
//         }
//     }
//     return sum;
// }


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array3 = GetArray(15, 1, 42);
Console.WriteLine($"[{String.Join(", ", array3)}]");
Console.WriteLine(GetMin(array3));
Console.WriteLine(GetMax(array3));
Console.WriteLine($"Разница между максимальным и минимальниым элементом массива = {GetMax(array3) - GetMin(array3)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
       arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int GetMin(int[] arr)
{
    int min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        
        if(min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}

int GetMax(int[] arr)
{
    int max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}