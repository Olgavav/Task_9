// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

Console.Clear();
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()!);

void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);