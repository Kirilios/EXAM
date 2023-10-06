/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/
Console.Clear();
string[] array = { "Hello", "2", "world", ":-)", "cyberpunk", "HL3" };
string[] GiveBackNewMassive(string[] array)
{
    string[] newArray = { "String.Empty" };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 3)
        {
            newArray = newArray.Append(array[i]).ToArray();
        }
    }
    return newArray;
}
void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.WriteLine("]");
}
PrintArray(array);
Console.WriteLine();
GiveBackNewMassive(array);




