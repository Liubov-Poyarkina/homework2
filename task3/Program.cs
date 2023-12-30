// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100);

int FirstNumber = num / 10;

int SecondNumber = num % 10;

Console.WriteLine(num);
Console.WriteLine(FirstNumber);
Console.WriteLine(SecondNumber);

if(FirstNumber > SecondNumber)
{
    Console.WriteLine($"Число {FirstNumber} больше");
}
else
{
    Console.WriteLine($"Число {SecondNumber} больше");
}