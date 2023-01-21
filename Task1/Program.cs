/*Напишите программу, которая принимает на вход 
(пятизначное) любое число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int number = InputInt("Введите число ");

Validate(number);

bool Validate(int num)
{
    int revNum = 0;
    int normalNum = num;
    int temp = 0; 
    while (num > 0)
    {
        temp = num % 10;
        revNum = revNum * 10 + temp;
        num = num / 10;
    }
    if (normalNum == revNum)
    {
        System.Console.WriteLine($"Число {normalNum} - палиндром.");
        return true;
    }
    else
    {
        System.Console.WriteLine($"Число {normalNum} не является палиндромом.");
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