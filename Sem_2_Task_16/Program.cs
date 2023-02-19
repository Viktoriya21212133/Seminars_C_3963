// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Водим числа 1 и 2 и сразу их парсим!
Console.WriteLine ("Inter first number: ");
int NumA = int.Parse(Console.ReadLine()??"0"); 
Console.WriteLine ("Inter second number: ");
int NumB = int.Parse(Console.ReadLine()??"0"); 

// Применяем невозвратный метод void
void SQRtest(int num1, int num2)
{
    if (num1 == num2*num2)
    {
        Console.WriteLine ($"First number {num1} sqr second number {num2}");
    }
    else 
    { 
        Console.WriteLine ($"First number {num1} is not sqr second number {num2}");
    }
}    

SQRtest (NumA,NumB);
SQRtest (NumB,NumA);
