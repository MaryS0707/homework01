/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int GetNumber (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
            Console.WriteLine("Ввели не число");
    }
    return result;
}

int num1 = GetNumber("Введите число 1: ");
int num2 = GetNumber("Введите число 2: ");
int num3 = GetNumber("Введите число 3: ");

if (num1 > num2)
{
    if (num1 > num3)
        Console.WriteLine($"{num1}, {num2}, {num3} -> {num1}");
    else
        Console.WriteLine($"{num1}, {num2}, {num3} -> {num3}");
}

else
{
    if(num2 > num3)
        Console.WriteLine($"{num1}, {num2}, {num3} -> {num2}");
    else
        Console.WriteLine($"{num1}, {num2}, {num3} -> {num3}");
}