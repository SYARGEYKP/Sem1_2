// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InputInt("Введите первое число");
int b = InputInt("Введите второе число");
int c = InputInt("Введите третье число");

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
System.Console.WriteLine($"максимальное число из {a}, {b}, {c} равно {max}");
