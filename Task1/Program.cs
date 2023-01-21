/*Напишите программу, которая принимает на вход 
(пятизначное) любое число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int number = InputInt("Введите число ");
int reverseNumber = 0;
int normalNumber = number;
int temp = 0;

while (number > 0)
{
    temp = number % 10;
    reverseNumber = reverseNumber*10 + temp;
    number = number / 10;
}

Validate(normalNumber, reverseNumber);

bool Validate(int num, int revNum)
{
    if (num == revNum)
    {
        System.Console.WriteLine($"Число {num} - палиндром.");
        return  true;
    }
    else
    {
        System.Console.WriteLine($"Число {num} не является палиндромом.");
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