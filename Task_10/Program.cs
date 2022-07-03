//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Ведите трехзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum1 = num/10;
int newNum2 = newNum1%10;
Console.WriteLine(newNum2);
