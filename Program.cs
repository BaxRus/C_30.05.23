// Семинар от 30.05.23 Сишарп семинар 4
/*

//Задача 25: Напишите цикл (***Функцию***), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Power(int arg1, int exponent)
{
    return arg1 = Convert.ToInt32(Math.Pow(arg1, exponent));
}

bool Valid(int exponent)
{
    if (exponent < 0)
    {
        Console.Write("Число В должно быть больше 0!");
        return false;
    }
    else
    {
        return true;
    }
}
if (Valid(num2) == true)
{
    Console.Write($"Число {num1} в степени {num2} равно {Power(num1, num2)}");
}
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumAllDigit(int arg)
{
    int result = 0;
    while (arg > 0)
    {
        result += arg % 10;
        arg = arg / 10;
    }
    return result;
}
Console.Write($"Сумма все цифр числа {num} равна {SumAllDigit(num)}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());


int[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    int[] RandomArray = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = rand.Next(MinValue, MaxValue + 1);
    }
    return RandomArray;
}


void PrintRandomArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}


int[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
*/
