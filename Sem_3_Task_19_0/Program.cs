// Напишите программу, которая принимает на вход пятизначное значение и проверяет является ли оно палиндромом

// Водим пятизначное число для его проверки и сразу его парсим!
Console.WriteLine ("Inter five-digit number: ");
int Number = int.Parse(Console.ReadLine()??"0"); 

//Находим первое число
int FirstNumber = (Number/10000)%10;
//Console.WriteLine (FirstNumber);
//Находим второе число
int SecondNumber = (Number/10) % 10;
//Console.WriteLine (SecondNumber);
//Находим четвертое число
int FourthNumber = (Number/10) % 10;
//Console.WriteLine (FourthNumber);
//Находим пятое число
int FifthNumber = Number % 10;
//Console.WriteLine (FifthNumber);
//Начинаем проверку для начала на пятизначность 
if (Number>10000 && Number<100000)
{
    // Пошли в цикл проверки на палиндром
        if (FirstNumber == FifthNumber && FourthNumber == SecondNumber)
        Console.WriteLine ("This number is palindome");
        else
        {
        Console.WriteLine ("This number is not palindrome");
        }
} 
else
Console.WriteLine ("This number is not five-digit number");
