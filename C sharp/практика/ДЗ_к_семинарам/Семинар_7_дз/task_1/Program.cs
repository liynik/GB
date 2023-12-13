//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// M=17

void ShowRealNumbers(int currentNumber, int number)
{   
    if (currentNumber <= number)
    {
        Console.Write(currentNumber + " ");
        ShowRealNumbers(currentNumber + 1, number);
    }
}

Console.Write("Введите число N: ");
if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
{
    Console.Write($"N={number} => ");
    ShowRealNumbers(17, number);
    Console.WriteLine();
}
else { Console.WriteLine("Некорректный ввод. Введите положительное целое число."); }