// Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Приглашение на ввод числа
Console.WriteLine ("Enter number day week: ");

// Считываем данные с ввода числа 
string? LineDay = Console.ReadLine ();

//Пасрим введенное число
if (LineDay !=null)
{
 int DayNumber = int.Parse(LineDay);

//Условие защиты от неверного числа 
if (DayNumber>7)
    Console.WriteLine("ERROR!");

string[] WeekDay = new string[7];
WeekDay[0] = "Monday";
WeekDay[1] = "Tuesday";
WeekDay[2] = "Wednesday";
WeekDay[3] = "Thursday";
WeekDay[4] = "Friday";
WeekDay[5] = "Saturday";
WeekDay[6] = "Sunday";

//Выводим на экран значение дня недели 
Console.WriteLine (WeekDay [DayNumber-1]);
}














//Выполняем условие задачи
//string [] WeekDay = WeekDay [7];
//WeekDay[0] = "Monday";
//WeekDay[1] = "Tuesday";
//WeekDay[2] = "Wednesday";
//WeekDay[3] = "Thursday";
//WeekDay[4] = "Friday";
//WeekDay[5] = "Saturday";
//WeekDay[6] = "Sunday";
//}
//Выводим на экран значение дня недели 
//Console.WriteLine (WeekDay[DayNumber-1]);
//}