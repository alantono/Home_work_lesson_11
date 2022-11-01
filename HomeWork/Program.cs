// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.
int n = 5;
string[]array = new string[n];

void DataEnter(string[]_array)
{for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i} элемент строкового массива: ");
    array[i] = Console.ReadLine();
    
}
}
 void PrintArray(string[]_array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
 DataEnter(array);
 PrintArray(array);
 
 
 

