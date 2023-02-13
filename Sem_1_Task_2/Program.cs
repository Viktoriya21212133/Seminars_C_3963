// Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее

// Приглашение на ввод чисел 
Console.WriteLine ("Enter number 1: ");
Console.WriteLine ("Enter number 2: ");

// Считываем данные с кода
string? Number1 = Console.ReadLine ();
string? Number2 = Console.ReadLine ();

// Парсим введенные числа
if (Number1 !=null && Number2 !=null)
{
 int num1 = int.Parse(Number1);
 int num2 = int.Parse(Number2);

  //Вводим проверку условия большее-меньшее
  if (num1>num2)

   Console.WriteLine("the first number is greater than the second");

 else
 
  Console.WriteLine("the second number is greater than the first");
 
}