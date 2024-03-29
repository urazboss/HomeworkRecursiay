﻿/*
Задача 1: Задайте значения M и N. Напишите 
программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не 
использовать циклы.

System.Console.Write("Введите число M: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Print(N, M));
string Print(int start, int end)
{
    if(start == end )
        return start.ToString();
    return $"{start} {Print(++start, end)}";
}
*/
// ------------------------------------------------------------------------------------------
/*Задача 2: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.
Console.Clear();
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0) return n+1;
    else if(n == 0) return akkerman(m - 1, 1);
    else 
    return akkerman(m - 1, akkerman(m, n - 1));

}
Console.Write($"Функция Аккермана равно {akkerman(m, n)}");
*/
// ----------------------------------------------------------------------------------------
/*Задача 3: Задайте произвольный массив. Выведете 
его элементы, начиная с конца. Использовать 
рекурсию, не использовать циклы.*/
class MainReturn 
{ 
static void Main(string[] args) 
    { 
        int[] array = { 1, 2, 5, 0, 10, 34 }; 
 
        PrintArrayReversed(array, array.Length - 1); 
    } 
 
    static void PrintArrayReversed(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " " ); 
            PrintArrayReversed(arr, index - 1); 
        } 
  
    } 
}

