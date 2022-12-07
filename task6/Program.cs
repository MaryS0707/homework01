/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
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

int num = GetNumber("Введите число: ");

if (num % 2 == 0)
{
    Console.WriteLine($"{num} -> да");
}
else
{
     Console.WriteLine($"{num} -> нет");
}