// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа 

// Приглашение на ввод числа
Console.WriteLine ("Enter number of threes: ");

// Считываем число 
string? LineN = Console.ReadLine ();

// Парсим введенное число
if (LineN !=null)
{
    int number = int.Parse (LineN);
      
    if (number > 100 && number < 1000)
    {
    int res = (number/10) %10;
    Console.WriteLine ("last number:"+ res);
    }
    else
    {
    Console.WriteLine ("Error!");
    }
    //Console.WriteLine ("last number:" + res);
}

