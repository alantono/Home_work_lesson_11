// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.
int n = 5;
int str = 3;
string[]array = new string[n];
string[]array3 = new string[n];

void DataEnter(string[]_array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i} элемент строкового массива: ");
        array[i] = Console.ReadLine();
    }
}
 void PrintArray(string[]_array)
{
    for (int i = 0; i < n; i++)
    {
       Console.Write($"{_array[i]}, ");
    }
    Console.WriteLine();
}
void CreatNewArray(string[]_array, string[]_array3)
{
    for (int i = 0; i < n; i++)
    {
        if (_array[i].Length <= str)
            _array3[i] = _array[i];
    }
    Console.WriteLine();
}
void PrintArray3(string[]_array3)
{
    for (int i = 0; i < n; i++)
    {
        if (_array3[i] != null)
        Console.Write($"{_array3[i]}, ");
    }
    Console.WriteLine();
}
 DataEnter(array);
 PrintArray(array);
 CreatNewArray(array, array3);
 PrintArray3(array3);
 
 
 

