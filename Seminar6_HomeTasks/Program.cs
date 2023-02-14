Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] array = new int[32];
// int i = 0;
// while(true)
// {
//     System.Console.WriteLine("Enter a number (enter 'Start' after last number has been entered): ");
//     string Str = Console.ReadLine();
//     if (Str == "Start") break;
//     else
//     {
//         array[i] = int.Parse(Str);
//         i++;
//     }
// }

// System.Console.WriteLine(String.Join("", array));

// int count = 0;
// for (int j = 0; j < i; j++)
// {
//     if (array[j] > 0) count += 1;
// }

// System.Console.WriteLine(count);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2-b1)/(k1-k2)

double GetNumber(string Str)
{
    System.Console.WriteLine($"Enter {Str}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

// double b1 = GetNumber("b1"); //
// double k1 = GetNumber("k1"); //
// double b2 = GetNumber("b2"); //
// double k2 = GetNumber("k2"); //

void CrossPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"The cross point is at {x};{y}");
}

// CrossPoint(b1, k1, b2, k2);

// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8


void FibonacciNums(int N) // без рекурсии
{
    double[] collection = new double[N];
    if(N == 1) System.Console.WriteLine("The Fibonacci number is: 0");
    else if (N == 2) System.Console.WriteLine("The Fibonacci number is: 0 1");
    else
    {
        collection[0] = 0;
        collection[1] = 1;
        for (int i = 2; i < N; i++)
        {
            collection[i] = collection[i-1] + collection[i-2];
        }
        System.Console.WriteLine(String.Join(" ", collection));
    }
}   

double num = GetNumber ("number");
// FibonacciNums(num); // без рекурсии

double Fibonacci(double N) // с рекурсией
{
    if (N == 1) return 0;
    else if(N == 2) return 1;
    else
    {
        return Fibonacci (N-1) + Fibonacci(N-2);
    }
}

System.Console.Write("The Fibonacci number is: ");
for (int i = 1; i < num+1; i++)
{
   System.Console.Write($"{Fibonacci(i)} ");
}

