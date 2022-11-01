// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.
int n = 5;
string[]array = new string[n];

for (int i = 0; i < n - 1; i++)
{
    Console.Write($"Введите {i} элемент строкового массива: ");
    string.TryParse(Console.ReadLine()!, out array[i]);
}


Console.WriteLine("Hello, World!");