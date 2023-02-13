// Напишите программу, которая на вход принимает число N, а на выходе показывает все целые числа в промежутке от -N до N 

// Приглашение на ввод числел
Console.WriteLine ("Enter number N: ");

// Считываем данные с ввода числа 
string? LineN = Console.ReadLine ();

//Пасрим введенные числа
if (LineN !=null)
{
 int N = int.Parse(LineN);


//определяем массив для вывода
string res = string.Empty;

//определяем переменную для отрицательных чисел
int neg = (-1)*N;

// входим в цикл для записи
while (neg <= N)
{
    res = res + neg+ ", ";
    neg = neg + 1;
}
Console.WriteLine(res);
}