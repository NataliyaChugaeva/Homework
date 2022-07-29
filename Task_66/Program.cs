// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int a = InputInt("Введите число A:");
int b = InputInt("Введите число B:");
Console.Write($"Сумма натуральных элементов от {a} до {b} = {CountNaturalSum(a, b)}");

int InputInt(string output)
{
 Console.Write(output);
 return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int a, int b)
{
 if (a == b)
 return b;
 return b + CountNaturalSum(a, b - 1);
}