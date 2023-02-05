// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = new int[10];
Console.WriteLine($"Длинна массива = {array.Length}");
Console.WriteLine();
int max = 0;
int min = 0;
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 0; i < array.Length; i++)
{
    sum = max + min;
    if (array[i]>max)
    {
        max = array[i];
    }
    else if (array[i]<min)
    {
        min = array[i];
    }
}
foreach (int item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine($" Максимальное число массива = {max}");
Console.WriteLine($" Минимальное число массива = {min}");
Console.WriteLine($" Сумма max и min числа = {sum}");