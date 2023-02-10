// Напишите программу, которая на вход принимает число и выдает его квадрат

//Приглашение на ввод числа
Console.Write("Enter your number: ");

// считывает данные с кода 
string? inputNum = Console.ReadLine ();
// Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
   //Парсим введенное число
    int number = int.Parse(inputNum);


// Находим квадрат числа
int outNum = number*number;

// Выводим данные в консоль
Console.Write ("Square number: ");
Console.Write (outNum);
}

