// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PositiveCounts(int m)
{
    int count = 0;
    for (int i = 1; i <= m; i++)
    {
        Console.Write($"Введите {i} число: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество чисел:");
int m = int.Parse(Console.ReadLine());

int counts = PositiveCounts(m);
Console.Write($"Количество четных чисел: {counts} ");

