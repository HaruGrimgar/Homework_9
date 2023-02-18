/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int SumOfNumbers( int start, int finish)
{
    if (start > finish)
    {
        return 0;
    }
    return SumOfNumbers(start + 1, finish) + start;
}

Console.WriteLine(SumOfNumbers(1, 15));
Console.WriteLine(SumOfNumbers(4, 8));