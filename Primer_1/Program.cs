// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int InputInt(string message)                                
{
    System.Console.Write($"{message}> ");                 
    int value;                                            
    if (int.TryParse(Console.ReadLine(), out value))      
    {                                                      
        return value;                               
    }                                                       
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                  
    return 0;  
}                                           

bool ValidateNum(int num1, int num2)
{
    if (num1 == 0 && num2 == 0)
    {
        System.Console.WriteLine("Ноль в нулевой степени невозможно определить"); // сделал проверку на такой случай
        return false;
    }
    if (num2 < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
return true;
}
int num1 = InputInt ("Введите число возводимое в степень: ");
int num2 = InputInt ("Введите число для возведения в степень первого: ");    
if (ValidateNum(num1, num2))
{
    Console.WriteLine($"Число {num1} в натуральной степени {num2} = {Math.Pow(num1, num2)}");
}