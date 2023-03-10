// Напишите программу, которая будет переводить введенное число из десятичной в двоичную систему исчесления

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод, который ничего не вернет, но выведет результат
void PrintData (string message)
 {
    Console.WriteLine (message);
 }


// Метод перевода
string DecToBin (int num)
{
    string res = string.Empty;
    while (num>0)
    {
        res = num%2+res;
        num = num/2;
    }
return res;    
}

int num = ReadData ("Enter number: ");
string result = DecToBin (num);
PrintData ("Number in binary = "+ result);