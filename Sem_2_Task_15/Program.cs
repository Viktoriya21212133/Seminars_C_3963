// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли она выходным днем
// *Использовать конструкцию Dictionary

// Пишем словарь
Dictionary <int, string> weekday = new Dictionary <int, string>();

weekday.Add (1, "weekday - Monday");
weekday.Add (2, "weekday - Tuesday");
weekday.Add (3, "weekday - Wednesday");
weekday.Add (4, "weekday - Thursday");
weekday.Add (5, "weekday - Friday");
weekday.Add (6, "day off - Saturday");
weekday.Add (7, "day off - Sunday");

// Приглашение на ввода числа
Console.Write("Enter your number: ");
//Парсим число
string? days = Console.ReadLine();
if (days!=null)
{
int day = Int32.Parse(days);
 // Проверяем значения
    if (weekday.ContainsKey (day))
    {
    Console.WriteLine (weekday[day]);
    }
    else
    {
    Console.WriteLine ("Is not day of week");
    }
    
}



