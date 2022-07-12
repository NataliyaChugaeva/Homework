// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
int numC = 1;
for (int i = 0; i < numB; i++ )
{
numC *= numA;
}

Console.WriteLine  ($"Число A возведенно в степень B,получили результат:{numC}");
Console.ReadKey();
