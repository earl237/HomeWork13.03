/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();
Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNaturalNumbers(m, n);

int SumNaturalNumbers(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        return n + SumNaturalNumbers(m, n - 1);
    }
}
Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");