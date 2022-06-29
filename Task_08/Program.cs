//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;
 int index = 0;
while (N >= a)
{     
   if (a%2==0)
   {
     index=index+1;
     a = a + 2;
   };
   
}
Console.WriteLine($"");