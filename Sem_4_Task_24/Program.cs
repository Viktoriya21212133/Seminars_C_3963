// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// метод вывода результатов
void PrintResult (string message)
{
    Console.WriteLine (message);
}

// простой метод 
int SumSuple (int numA) 
 {
     int sum = 0; 
         for (int i=1; i<=numA; i++)
         {
             sum+=i;
         }   
         
     return sum;
 }

// можно использовать формулу Гаусса арифметической прогрессии
int SumGausse (int numA)
{
    return ((1+numA) * numA)/2;
}

int numA = ReadData ("Enter number A: ");
// Счетчик времени на метод SumSuple
DateTime d1 = DateTime.Now;
int res1 = SumSuple (numA);
Console.WriteLine (DateTime.Now - d1);

PrintResult ("sum of numbers from 1 to A (simple method) = "+res1);
// Счетчик времени на метод SumSuple
DateTime d2 = DateTime.Now;
int res2 = SumGausse(numA);
Console.WriteLine (DateTime.Now - d2);
PrintResult ("sum of numbers from 1 to A (method Gaussa)= "+res2);
