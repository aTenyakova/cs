// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number%2;
if (result == 0)
{
    Console.WriteLine($"Число {number} является чётным");
}
else Console.WriteLine($"Число {number} является нечётным");