// Напишите программу, которая выводит случайное число из отрезка 10-99 и показывает наибольшую цифру этого числа

//  Объявляем случайное число вызывая рандомайзер. При этом new - выделает оперативную память под это число
System.Random numSintezator = new System.Random ();
//  Вариант 1
// Определяем переменную, в которую положим случайное число
// rnd - сокращение от Random
// Next - функция, которая возращает число, возвращает без последнего числа, т.е. 99 последнее число
int RndNumber = numSintezator.Next (10,100);
// посмотрим, какое число выдаст 
Console.WriteLine(RndNumber);
//  Вводим первую переменную, сюда положим старший разряд
int FirstNumber = RndNumber/10; 
// Вводим вторую переменную, сюда положим вторую цифру
int SecondNumber = RndNumber%10;

// Дальше смотрим какая из цифр больше первая или вторая, и выводим на экран
if (FirstNumber>SecondNumber)
     {
        Console.WriteLine ("The first number " +FirstNumber+ " is greater than the second number " +SecondNumber);
     }
else
    {
           Console.WriteLine ("The second number " +SecondNumber+ " is greater than the first number " +FirstNumber);
    }

//  Вариант 2
System.Random numSintezator = new System.Random ();
// char - тип смиволы, буквы
// ToString превратить число в строку, которая состоит из букв, а дальше ToCharArray превратим строку в массив символов
char[] Digits = numSintezator.Next(10,100).ToString().ToCharArray();
// Вводим первое число, преобразуем символ с целочисленное значение и -48
int FirstNumber = ((int)Digits[0])-48;
// Вводим второе число, преобразуем символ с целочисленное значение и -48
int SecondNumber = ((int)Digits[1])-48;
// Выведем на экран число, которое сгенерировали
Console.WriteLine (Digits);
// Тернарный оператор - Переменная = (условие)? <значение1> : <значение2>
int resalt = (FirstNumber>SecondNumber)?resalt=FirstNumber:resalt=SecondNumber;

// Вывод на экран результата 
Console.WriteLine (resalt);

// Вариант 3
System.Random numSintezator = new System.Random ();
int RndNumberArr = numSintezator.Next (10,100);
Console.WriteLine (RndNumberArr);
int[] indxAnsw = new int[90];
// Заготовленная таблица
indxAnsw[0]=1; indxAnsw[2]=1; indxAnsw[2]=2; indxAnsw[3]=3; indxAnsw[4]=4; indxAnsw[5]=5; indxAnsw[6]=6; indxAnsw[7]=7; indxAnsw[8]=8; indxAnsw[9]=9;
indxAnsw[10]=2; indxAnsw[11]=2; indxAnsw[12]=2; indxAnsw[13]=3; indxAnsw[14]=4; indxAnsw[15]=5; indxAnsw[16]=6; indxAnsw[17]=7; indxAnsw[18]=8; indxAnsw[19]=9;
indxAnsw[20]=3; indxAnsw[21]=3; indxAnsw[22]=3; indxAnsw[23]=3; indxAnsw[24]=4; indxAnsw[25]=5; indxAnsw[26]=6; indxAnsw[27]=7; indxAnsw[28]=8; indxAnsw[29]=9;
indxAnsw[30]=4; indxAnsw[31]=4; indxAnsw[32]=4; indxAnsw[33]=4; indxAnsw[34]=4; indxAnsw[35]=5; indxAnsw[36]=6; indxAnsw[37]=7; indxAnsw[38]=8; indxAnsw[39]=9;
indxAnsw[40]=5; indxAnsw[41]=5; indxAnsw[42]=5; indxAnsw[43]=5; indxAnsw[44]=5; indxAnsw[45]=5; indxAnsw[46]=6; indxAnsw[47]=7; indxAnsw[48]=8; indxAnsw[49]=9;
indxAnsw[50]=6; indxAnsw[51]=6; indxAnsw[52]=6; indxAnsw[53]=6; indxAnsw[54]=6; indxAnsw[55]=6; indxAnsw[56]=6; indxAnsw[57]=7; indxAnsw[58]=8; indxAnsw[59]=9;
indxAnsw[60]=7; indxAnsw[61]=7; indxAnsw[62]=7; indxAnsw[63]=7; indxAnsw[64]=7; indxAnsw[65]=7; indxAnsw[66]=7; indxAnsw[67]=7; indxAnsw[68]=8; indxAnsw[69]=9;
indxAnsw[70]=8; indxAnsw[71]=8; indxAnsw[72]=8; indxAnsw[73]=8; indxAnsw[74]=8; indxAnsw[75]=8; indxAnsw[76]=8; indxAnsw[77]=8; indxAnsw[78]=8; indxAnsw[79]=9;
indxAnsw[80]=9; indxAnsw[81]=9; indxAnsw[82]=9; indxAnsw[83]=9; indxAnsw[84]=9; indxAnsw[85]=9; indxAnsw[86]=9; indxAnsw[87]=9; indxAnsw[88]=9; indxAnsw[89]=9;

// Выводим данные в консоль
Console.WriteLine(indxAnsw[RndNumberArr-10]);


