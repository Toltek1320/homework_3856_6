// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.Write($"-> {sum}");
int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    int[] numbers = new int [count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
void PrintArray(int[] array)
{    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами: X = {x}; Y = {y}");

// Задача 44:выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1
// Если N = 7 --> 0 1 1 2 3 5 8

Console.Write("Введите значение n: ");
double n = Convert.ToInt32(Console.ReadLine());
double f(int n)
{
    if(n == 0) return 0;
    if(n == 1 || n == 2) return 1;
    else return f(n - 1) + f(n - 2);
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"f({i + 1}) = {f(i)}");
}
