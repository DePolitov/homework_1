// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число=");
string number1 = Console.ReadLine()!;
Console.Write("Введите второе число=");
string number2 = Console.ReadLine()!;
int c = int.Parse(number1);
int d = int.Parse(number2);
if (c > d)
{
    Console.WriteLine($"Максимальное число {c}\n");
}
else
{
    Console.WriteLine($"Максимальное число {d}\n");
}
