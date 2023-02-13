using System;
using System.Linq;
// Напишите программу, которая принимает на вход три числа и выдает максимальное из трех чисел 

// Приглашение на ввод числел
Console.WriteLine ("Enter number 1: ");
Console.WriteLine ("Enter number 2: ");
Console.WriteLine ("Enter number 3: ");

// Считываем данные с ввода числа 
string? InputNumber1 = Console.ReadLine ();
string? InputNumber2 = Console.ReadLine ();
string? InputNumber3 = Console.ReadLine ();

//Пасрим введенные числа
if (InputNumber1 !=null && InputNumber2 !=null && InputNumber3 !=null)
{
 int Number1 = int.Parse(InputNumber1);
 int Number2 = int.Parse(InputNumber2);
 int Number3 = int.Parse(InputNumber3);

//Определяем массив из чисел 
int[] MaxNumber = {Number1, Number2, Number3}; 

//Выводим на экран значение максимума 
//новая команда, надо записать. Для минимума работает также
Console.WriteLine("Max number is " + MaxNumber.Max());
}
