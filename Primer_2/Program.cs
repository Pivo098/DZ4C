// Задача 27: Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int NumSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10; 
        num = num / 10;
    }
    return result;
}

int num = ReadInt("Введите число:");
System.Console.WriteLine($"Сумма всех чесел в цифре {num} = {NumSum(num)}");