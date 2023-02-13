// Напишите программу, которая на вход принимает число и выдает является ли оно четным (делится ли 2 без остатка)

// Приглашение на ввод числа
Console.WriteLine ("Enter number:");

// Считываем число с ввода
string? InputNumber = Console.ReadLine();

// Парсим введенное число 
if (InputNumber != null)
{
    int Number = int.Parse (InputNumber);

// Входим в проверку условия четный-нечетный
if (Number % 2 == 0)
    Console.WriteLine ("Even number"); //Even - четное
else
{
    Console.WriteLine ("odd number"); //odd - нечетное
}
}