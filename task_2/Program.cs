// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber;

if (secondNumber > firstNumber)
{
    maxNumber = secondNumber;
}
if (thirdNumber > maxNumber)
{
    maxNumber = thirdNumber;
}
Console.WriteLine($"{maxNumber} - максимальное число");