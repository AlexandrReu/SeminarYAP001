// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int number = new Random().Next(100, 1000);
// int number1 = number % 100;
// number1 = number1 / 10;
// Console.WriteLine($"Вторая цифра числа {number} = {number1}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите, пожалуйста, число.");
// int number = int.Parse(Console.ReadLine());
// int number3 = 0;

// if(number >99999)
// {
//     Console.WriteLine("Введено некорректное число.");
// }
// else if((number > 99) && (number < 1000))
// {
//     number3 = number % 10;
//     Console.WriteLine($"Третья цифра числа {number} = {number3}");
// }
// else if((number > 999) && (number < 10000))
// {
//     number3 = number % 100;
//     number3 = number3 / 10;
//     Console.WriteLine($"Третья цифра числа {number} = {number3}");
// }
// else if((number > 9999) && (number < 100000))
// {
//     number3 = number % 1000;
//     number3 = number3 / 100;
//     Console.WriteLine($"Третья цифра числа {number} = {number3}");
// }
// else 
// {
//     Console.WriteLine("В данном числе третьей цифры нет.");
// }
//Можно было решить через перевод числа в массив, но я так понял, что забегать вперед не надо.

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите ,пожалуйста, цифру.");
int dayNumber = int.Parse(Console.ReadLine());
if((dayNumber == 6) || (dayNumber == 7))
{
    Console.WriteLine("Ура, выходной, проведите его с пользой!");
}
else if((dayNumber > 0) && (dayNumber < 6))
{
    Console.WriteLine("Будний день, идите работать.");
}
else 
{
    Console.WriteLine("Такого дня недели не существует, или Вы на другой планете.");
}