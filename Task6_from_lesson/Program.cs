/*Напишите программу, которая выводит первые 
заданные элемента следующей последовательности: 
-> 12
1 2 2 3 3 3 4 4 4 4 5 5*/

int N = InputInt("Введите число ");
int count = 0;


if (Validate(N))
{
    for (int i = 1; i <= N; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (count == N)
            {
                break;
            }
            System.Console.Write($"{i} ");
            count++;
        }

    }
}

bool Validate(int num)
{
    if (num > 0)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("0");
        return false;
    }
}

int InputInt(string message)
{
    System.Console.Write(message + "> ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

