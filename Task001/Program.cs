// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.


class Program 
{
    static void Main(string[] arsg)
    {
        string[] array = new string [4] {"Hello", "2022", "world", "};>"};
        string[] newarray = new string[array.Length];
        Console.WriteLine("Массив");
        PrintArray1(array);
        Console.WriteLine();
        Console.WriteLine("Новый массив ");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 4)
            {
                newarray[count] = array[i];
                count++;
            }
        }
        PrintArray2(newarray);      
    }
    static void PrintArray1(string[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length-1)
            {
                Console.Write(arr[i] + "");
            }
            else
            {
                Console.Write(arr[i] + ", ");
            }
            
        }
        Console.Write("]");
    }
    static void PrintArray2(string[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i <= array.Length - i - 1; i++)
        {
            if (i == (array.Length - 1) / 2)
            {
                Console.Write(array[i] + " ");
            }
            else
            {
                Console.Write(array[i] + " ");
            }
        }
        Console.Write(" ]");
    }
}