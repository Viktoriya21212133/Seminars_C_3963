// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

//  Объявляем случайное число вызывая рандомайзер. При этом new - выделает оперативную память под это число
System.Random numSintezator = new System.Random ();
// Определяем переменную, в которую положим случайное число
int num = numSintezator.Next (100,1000);
// посмотрим, какое число выдаст 
Console.WriteLine("Random number: "+num);
// Получим третью цифру
int lastNum = num%10;
// Получим первую цифру
int firstNum = num/100;
// Берем первое число+ последнее число 
int resalt = firstNum*10+lastNum;
// Выводим на экран результат
Console.WriteLine ("Resalt: "+resalt);
