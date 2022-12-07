/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
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

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
else
    Console.WriteLine($"max = {num2}, min = {num1}");