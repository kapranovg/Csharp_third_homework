/*Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

double N = InputDouble("Введите число N ");

for (double i = 1; i <= N; i++)
{
    double cubeNumber = Math.Pow(i, 3);
    System.Console.Write($"{cubeNumber}; ");
}

double InputDouble(string message)
{
    System.Console.Write(message + "> ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}