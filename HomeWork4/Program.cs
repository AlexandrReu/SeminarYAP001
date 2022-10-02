//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите число А: ");
// int firstNumb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B: ");
// int secondNumb = int.Parse(Console.ReadLine()!);

// Console.WriteLine(GetMult(firstNumb, secondNumb));


// double GetMult(int one, int two)
// {
//     double multi = Math.Pow(one, two);
//     return multi;
// }

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе {number} = {SumNumber(number)}");

// int SumNumber(int userNumb)
// {
//     int result = 0;
//     if(number >99999)
// {
//     Console.WriteLine("Введено некорректное число.");
// }
// else if((number > 9) && (number < 100))
// {
//     int temp1 = userNumb % 10;
//     int temp2 = userNumb/10;
//     result = temp1 + temp2;
// }
// else if((number > 99) && (number < 1000))
// {
//     int temp1 = userNumb % 10;
//     int temp2 = userNumb/10%10;
//     int temp3 = userNumb/100;
//     result = temp1 + temp2 + temp3;
// }
// else if((number > 999) && (number < 10000))
// {
//     int temp1 = userNumb % 10;
//     int temp2 = userNumb/10%10;
//     int temp3 = userNumb/100%10;
//     int temp4 = userNumb/1000;
//     result = temp1 + temp2 + temp3 + temp4;
// }
// else if((number > 9999) && (number < 100000))
// {
//     int temp1 = userNumb % 10;
//     int temp2 = userNumb/10%10;
//     int temp3 = userNumb/100%10;
//     int temp4 = userNumb/1000%10;
//     int temp5 = userNumb/10000;
//     result = temp1 + temp2 + temp3 + temp4 + temp5;
// }
//     return result;
// }




