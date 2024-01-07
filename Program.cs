/*
Задача 1: Задайте значения M и N. Напишите 
программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не 
использовать циклы.
*/
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
