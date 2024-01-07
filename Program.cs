/*
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
неотрицательных числа m и n.*/
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
