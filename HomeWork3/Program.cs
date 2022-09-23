// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число.");
// int userNumber = int.Parse(Console.ReadLine());
// int number = userNumber;
// int reverse = 0;

// if(userNumber > 9999 && userNumber < 100000)
// {
// for(int i = 0; i < 5; i++)
// {
//     int rev = number%10;
//     reverse = reverse*10 + rev;
//     number = number/10;
// }
// if(userNumber == reverse)
// {
//     Console.WriteLine($"Число {userNumber} - является палиндромом.");
// }
// else
// {
//     Console.WriteLine($"Число {userNumber} - не является палиндром.");
// }
// }
// else
// {
//     Console.WriteLine("Введено некорректное число.");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты двух точек в пространстве.");
Console.WriteLine("Первая координата первой точки: ");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая координата первой точки: ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Третья координата первой точки: ");
int xc = int.Parse(Console.ReadLine());

Console.WriteLine("Первая координата второй точки: ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая координата второй точки: ");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Третья координата второй точки: ");
int yc = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xa - ya,2) + Math.Pow(xb - yb,2) + Math.Pow(xc - yc,2));

Console.WriteLine($"Расстояние между двумя точками в пространстве = {result:f2}");