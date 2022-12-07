/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int GetNumber (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.Write(message);
        if((int.TryParse(Console.ReadLine(), out result)) && result > 1)
        {
            return result;
        }
        else
            Console.WriteLine("Ввели не число/не подходящее число");
    }
    return result;
}

int num = GetNumber("Введите число: ");
Console.Write(num + " -> ");

for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
 
}