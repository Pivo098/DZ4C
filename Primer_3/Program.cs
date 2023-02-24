// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int[] Generare(int len, int minVal, int maxVal)
{
    int[] array = new int[len];
    Random random = new Random();
    for (int i =0; i < len; i++)
    {
        array[i] = random.Next(minVal, maxVal + 1);
    }
    return array;
}
void Print(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int len = ReadInt("Длинна массива: ");
int min = ReadInt("Начальное значение диапазона случайного числа: ");
int max = ReadInt("Конечное значение диапазона случайного числа: ");
int[] array = Generare(len, min, max);
Print(array);