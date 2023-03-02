// Напишите программу, которая принимает на вход числа (А и В) и выводит число А в натуральную степень В

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
// квадрат
int SquareSuple (int numA, int numB)
{
    int square = 0;
        for (int i=1; i<=numA; i++)
        {
            square = Convert.ToInt32(Math.Pow(numA, numB));
        }   
    return square;
}

// сумма 
int SumSuple (int numA, int numB)
{
    int sum = 0;
        for (int i=1; i<=numA; i++)
        {
            sum = numA+numB;
        }   
    return sum;
}

// Разность 
int differenceSuple (int numA, int numB)
{
    int difference = 0;
    
        for (int i=1; i<=numA; i++)
        {
            difference = numA-numB;
            
        }   
    return difference; 
}
// Умножение 

int multiplicationSuple (int numA, int numB)
{
    int multiplication = 0;
    
        for (int i=1; i<=numA; i++)
        {
            multiplication = numA*numB;
            
        }   
    return multiplication; 
}
// Деление division

double divisionSuple (int numA, int numB)
{
    double division = 0;
    
        for (int i=1; i<=numA; i++)
        {
            division = numA/numB;
            
        }   
    return division; 
}

// Объявление переменных
int numA = ReadData ("Enter number A: ");
int numB = ReadData ("Enter number B: ");

// Объявление переменных для методов
int square1 = SquareSuple (numA,numB);
int sum1 = SumSuple (numA,numB);
int difference1 = differenceSuple (numA, numB);
int multiplication1 = multiplicationSuple (numA, numB);
double division1 = divisionSuple (numA, numB);

// Вызов методов
PrintResult ("Number A squared number B = "+square1);
PrintResult ("Sum Number A and B = "+sum1);
PrintResult ("difference Number A and B = "+difference1);
PrintResult ("multiplication Number A and B = "+multiplication1);
PrintResult ("division Number A and B = "+division1);