// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;

if (num<100) Console.WriteLine("Третьей цифры нет");
else 
     if (num>100) num1 = num%10;
     if (num>1000) num1 = num%100/10;
     if (num>10000) num1 = num%1000/100;
     if (num>100000) num1 = num%10000/1000;
     if (num>1000000) num1 = num%100000/10000;
     if (num>10000000) num1 = num%1000000/100000;

Console.WriteLine(num1);
