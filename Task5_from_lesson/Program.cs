/*Напишите программу, которая генерирует последовательность 
случайных чисел из 10 элементов в диапазоне от 1 до 10, 
и подсчитывает, сколько сгенерировалось чисел больше 5.*/

Random rnd = new Random();

int count = 0;

int[] listNumbers = new int[10];
for (int i = 0; i < listNumbers.Length; i++)
{
    listNumbers[i] = rnd.Next(1, 10);
    if (listNumbers[i] > 5)
    {
        count++;
    }
}

System.Console.WriteLine(string.Join(",", listNumbers));
System.Console.WriteLine($"Количество чисел больше 5: {count};");

