// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

int[] array = new int [8];
int len = array.Length;


void Fill_Array(int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < len; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
}

void Sort_Array_Abs(int[] array)
{
    int minPosition = 0;
    int temp = 0;
    for(int i = 0; i < len; i++)
    {
        minPosition = i;
        for(int j = i + 1; j < len; j++)
        {
            if(Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
        }
        temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

void Print_Array(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}");
        if(i < len - 1) Console.Write(", ");
    }
    Console.Write(" ]");
}

Console.Write("Неотсортированный массив: ");
Fill_Array(array);
Print_Array(array);
Console.WriteLine();
Console.Write("Отсортированный массив: ");
Sort_Array_Abs(array);
Print_Array(array);