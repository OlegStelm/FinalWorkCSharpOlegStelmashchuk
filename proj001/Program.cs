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
        Console.Write($"{arrayStart[i]}*");
    }
}
Console.WriteLine($"]");
