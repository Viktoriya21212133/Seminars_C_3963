// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

// Приглашение на ввод чисел
Console.WriteLine ("Enter number 1: ");
Console.WriteLine ("Enter number 2: ");

// Считываем данные с кода
string? NumLine1 = Console.ReadLine ();
string? NumLine2 = Console.ReadLine ();

// Парсим введенное число
if (NumLine1 !=null && NumLine2 !=null)
{
 int num1 = int.Parse(NumLine1);
 int num2 = int.Parse(NumLine2);
 
 //Проверяем условие задачи
  if (num2*num2 == num1)

   Console.WriteLine("true");

 else
 
  Console.WriteLine("False");
 
}