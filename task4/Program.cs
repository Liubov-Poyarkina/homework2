// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите число:");
string num = Convert.ToString(Console.ReadLine());

 for (int i = 0; i < num.Length; i++)
{
    Console.Write($"{num[i]}, ");
}
Console.Write("\b\b ");