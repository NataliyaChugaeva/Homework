// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


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