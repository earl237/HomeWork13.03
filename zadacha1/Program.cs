/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/
Console.Clear();
Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

NumberCounter(m , n);
void NumberCounter (int min, int max)
{
    if (min < 0 || max < 0 || max < min) 
        return;
    if (min % 2 == 0)
        Console.Write("{0,4}", min);
    NumberCounter(min+1, max);
}
