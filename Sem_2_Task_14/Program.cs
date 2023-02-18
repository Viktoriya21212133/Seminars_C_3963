// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// Водим число и сразу их парсим!
Console.WriteLine ("Inter number: ");
int Num = int.Parse(Console.ReadLine()??"0"); 
// входим в цикл на проверку деления без остатка
if (Num % 23 == 0 && Num % 7 == 0)
{
    Console.WriteLine ("multiple number");
}
else
{
    Console.WriteLine ("non-multiple number");
}
