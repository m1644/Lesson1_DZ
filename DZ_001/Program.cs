// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Результат - ");
if (numberA > numberB)
Console.WriteLine("Число А больше числа В");
else
{
    Console.WriteLine("Число А меньше числа В");
}
