/*Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший 
общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/
Console.Clear();
Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int gcd = GCD(m, n);
int GCD(int m, int n)
{
    if (n == 0)
    {
        return m;
    }
    else
    {
        return GCD(n, m % n);
    }
}
Console.WriteLine($"Наибольший общий делитель чисел {m} и {n}: {gcd}");