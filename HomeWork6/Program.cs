//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



Console.WriteLine("Введите количесво вводимых чисел.");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество чисел больше 0 = {UserNumb(size)}");

int UserNumb(int size)
{
    int count = 0;
   for(int i = 1; i <= size; i++)
   {
    Console.WriteLine($"Введите число №{i}");
    int numb = int.Parse(Console.ReadLine()!);
    if(numb > 0)
    {
        count++;
    }
    }
   return count;
} 
