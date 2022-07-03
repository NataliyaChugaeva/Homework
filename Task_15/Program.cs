// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру,обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

  if (num==1) Console.WriteLine("Нет");
  if (num==2) Console.WriteLine("Нет");
  if (num==3) Console.WriteLine("Нет");
  if (num==4) Console.WriteLine("Нет");
  if (num==5) Console.WriteLine("Нет");
  if (num==6) Console.WriteLine("Да");
  if (num==7) Console.WriteLine("Да");
else if (num>7) Console.WriteLine("Не является днём недели."); 

//if (num<=5) Console.WriteLine("Нет");