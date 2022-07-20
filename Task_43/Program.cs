﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
double numB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения числа k1:");
double numK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения числа b2:");
double numB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения числа k2:");
double numK2 = Convert.ToInt32(Console.ReadLine());

void FindYX (double b1,double k1, double b2,double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"Точка пересечения двух прямых находится в координатах: x = {x},y = {y}");
    
}

FindYX(numB1,numK1,numB2,numK2);