/*Задача.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.

Примеры:
[“hello”, “2”, “world”, “😊”] -> [“2”, “😊”]
[“1234”, “1567”, “-2”, “computer science”] -> [“2”]
[“Russia”, “Denmark”, “Kazan”] -> []
*/
// -------------------------------------------

string[] InitStringArray(string message)
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:", i + 1);
        stringArray[i] = Console.ReadLine();
    }
    Console.Write("Вы ввели следующие строки: [");

    for (int i = 0; i < n; i++)
    {
        Console.Write(stringArray[i]);
        if (i < stringArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");

    return stringArray;
}

string[] stringArray = InitStringArray("");