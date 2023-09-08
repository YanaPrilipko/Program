
using Student;

/*int a = 4.3;
short b = 10;
decimal k = (decimal)(a + b);
Console.WriteLine(k);
int c = 5;
int l = c * b;
Console.WriteLine(l);

//Console.WriteLine("Write to console result of several math functions:");

Console.Write("Please enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Please enter first number: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of {number1} and {number2} is {number1 + number2}");

Console.Write("Enter a number to calculate the circle: ");
int x = int.Parse(Console.ReadLine());
int pi = 2 * Math.PI * x;

Console.WriteLine($"The length of the circle is {pi}");
//DateTime dateTime = new DateTime.Now;

DateTime dateTime1 = new DateTime(2024, 01, 01);
DateTime dateTime2 = new DateTime(2023, 01, 01);
var difference = dateTime1.Subtract(DateTime.Now).Days;
var difference1 = DateTime.Now.Subtract(dateTime2).Days;

Console.WriteLine($"{difference} days left to New Year");
Console.WriteLine($"{difference1} days passed from New Year");*/


//Operators.Parcer();
/* int sum(int from, int to)
{
    if (from > to) return sum(to, from);
    if (from == to) return from;
    return from + sum(from + 1, to);
}
Console.WriteLine($"{sum(1,10)}");*/


//завдання 5 Методи

void Number()
{
    Console.Write("Please enter first number: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Please enter first number: ");
    int y = int.Parse(Console.ReadLine());
    int sum2;
    bool result;
    result = TrySumIFOdd(x, y, out sum2);
    Console.WriteLine($"{sum2} ");
    Console.WriteLine($"{result} ");
}

bool TrySumIFOdd(int x, int y, out int sum)
{
    sum = x + y;
    if (sum % 2 != 0) return true;
    return false;
}
Number();

int result = Method.MaxNumber(5, 6);
int result1 = Method.MaxNumber(5, 6, 7);
int result2 = Method.MaxNumber(5, 6, 10);
int result3 = Method.MinNumber(5, 6);
int result4 = Method.MinNumber(5, 6, 10);
int result5 = Method.MinNumber(5, 6, 7, 9);

Console.WriteLine($"{result}");
Console.WriteLine($"{result1}");
Console.WriteLine($"{result2}");
Console.WriteLine($"{result3}");
Console.WriteLine($"{result4}");
Console.WriteLine($"{result5}");