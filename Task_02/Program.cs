﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
 if (a>b)
 {
   max = a ;
 }
 else
 {
    max = b ;
 }
 Console.WriteLine($"max = {max}");