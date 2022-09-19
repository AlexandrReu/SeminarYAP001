/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

/*Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Наибольшее число {number1}, наименьшее число {number2}");
}
else
{
    Console.WriteLine($"Наибольшее число {number2}, наименьшее число {number1}");
} */
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());
int maxNumber = number1;

if (maxNumber < number2)
{
    maxNumber = number2;
}
if (maxNumber < number3)
{
    maxNumber = number3;
}
Console.WriteLine($"Максимальное число {maxNumber}");