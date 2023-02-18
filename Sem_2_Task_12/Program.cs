// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, 
// то программа выводит остаток от деления.

// Водим числа 1 и 2 и сразу их парсим!
Console.WriteLine ("Inter first number: ");
int FirstNum = int.Parse(Console.ReadLine()??"0"); 
// or - int FirstNum = Convert.ToInt32 (Console.ReadLine()); 
Console.WriteLine ("Inter second number: ");
int SecondNum = int.Parse(Console.ReadLine()??"0"); 
// or - int SecondNum = Convert.ToInt32 (Console.ReadLine()); 

// входим в цикл проверки
if (FirstNum/SecondNum == 0)
{
    Console.WriteLine ("multiple number");
}
else
{
int resalt = FirstNum/SecondNum;
Console.WriteLine (" non-multiple number, remainder = " +resalt);
}