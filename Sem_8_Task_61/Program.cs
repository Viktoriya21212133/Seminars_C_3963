// Выведите первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника. 

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// n! k!*(n-k)!
//       1
//      1 1
//     1 1 1

// Метод расчета факториала
long Factorial (int n)
{
    long res = 1;
    for (int i =2; i<=n; i++)
    {
        res = res*i;
    }
    return res;
}

//Метод вывода на экран
void PrintPaskaleTriangle (int nRow)
{
    for (int i=0; i<nRow; i++)
    {
        for (int k = 0; k<nRow-i; k++)
        {
            Console.Write (" ");
        }
        for (int j=0; j<=i;j++)
        {
        Console.Write (" ");
        Console.Write (Factorial(i)/(Factorial(j)*Factorial(i-j)));
        }
        Console.WriteLine ();
    }
}

// Обращение к методу печати
int countRow = ReadData ("Enter the number of lines triangle Pascal: ");
PrintPaskaleTriangle (countRow);