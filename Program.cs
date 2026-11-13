// 1
// PrintHeader("1");
// PrintHeader("2");

// static void PrintLine()
// {
//     Console.WriteLine("^_^ ^_^ ^_^ ^_^ ^_^");
// }

// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }


// 2.1
// Console.WriteLine(Max(3, 5));
// Console.WriteLine(Max(10, 2));

// static int Max(int a, int b)
// {
//     if (a > b) return a;
//     return b;
// }

// 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

// 3
// int[] arr = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(arr));
// Console.WriteLine(CountGreater(arr, 100));

// static double Average(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++) sum += arr[i];
//     return (double)sum / arr.Length;
// }

// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//         if (arr[i] > limit) count++;
//     return count;
// }

// 4
// Console.WriteLine(ToFahrenheit(0));
// Console.WriteLine(ToFahrenheit(100));
// Console.WriteLine(ToFahrenheit(37));

// static double ToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }

// 5
// Console.WriteLine(Factorial(5));
// for (int i = 2; i <= 50; i++)
//     if (IsPrime(i)) Console.Write(i + " ");
// Console.WriteLine();

// static long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 2; i <= n; i++) result *= i;
//     return result;
// }

// static bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     for (int i = 2; i * i <= n; i++)
//         if (n % i == 0) return false;
//     return true;
// }

// 6
// int a = ReadPositive("Число 1: ");
// int b = ReadPositive("Число 2: ");
// Console.WriteLine(a + b);
// static int ReadPositive(string message)
// {
//     int value;
//     do
//     {
//         Console.Write(message);
//         int.TryParse(Console.ReadLine(), out value);
//     } while (value <= 0);
//     return value;
// }

bool running = true;
while (running)
{
    Console.WriteLine("\n1 - Сумма");
    Console.WriteLine("2 - Max");
    Console.WriteLine("3 - Факториал");
    Console.WriteLine("4 - Ввод числа");
    Console.WriteLine("0 - Выход");
    Console.Write("Выбор: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Сумма = " + Sum(ReadPositive("a: "), ReadPositive("b: ")));
            break;
        case "2":
            Console.WriteLine("Max = " + Max(ReadPositive("a: "), ReadPositive("b: ")));
            break;
        case "3":
            Console.WriteLine("Факториал = " + Factorial(ReadPositive("n: ")));
            break;
        case "4":
            Console.WriteLine("Вы ввели: " + ReadPositive("число: "));
            break;
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}

static int Sum(int a, int b)
{
    return a + b;
}

static int Max(int a, int b)
{
    if (a > b) return a;
    return b;
}

static long Factorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

static int ReadPositive(string message)
{
    int value;
    do
    {
        Console.Write(message);
        int.TryParse(Console.ReadLine(), out value);
    } while (value <= 0);
    return value;
}