/*  Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int m;
Console.WriteLine("Enter the number of elements: ");
int.TryParse(Console.ReadLine()!, out m);
string[] arrayStart = new string[m];
for (int i = 0; i < arrayStart.Length; i++)
{
    Console.WriteLine("Enter an element: ");
    arrayStart[i] = Console.ReadLine()!;
}
Console.Write($"[");
for (int i = 0; i < arrayStart.Length; i++)
{
    if (i == arrayStart.Length - 1)
    {
        Console.Write($"{arrayStart[i]}");
    }
    else
    {
        Console.Write($"{arrayStart[i]},");
    }
}
Console.WriteLine($"]");
int n = new Random().Next(4);
if (n == 0)
{
    Console.WriteLine($"[]");
}
else
{
    string[] arrayOut = new string[n];
    Console.Write($"[");
    for (int i = 0; i < arrayOut.Length; i++)
    {
        if (i == arrayOut.Length - 1)
        {
            int a = new Random().Next(arrayStart.Length);
            arrayOut[i] = arrayStart[a];
            Console.Write($"{arrayOut[i]}");
        }
        else
        {
            int a = new Random().Next(arrayStart.Length);
            arrayOut[i] = arrayStart[a];
            Console.Write($"{arrayOut[i]},");
        }
    }
    Console.WriteLine($"]");
}
