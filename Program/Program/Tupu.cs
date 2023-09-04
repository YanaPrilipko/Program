
double a = 4.3;
short b = 10;
decimal k = (decimal) (a + b);
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
double pi = 2 *Math.PI * x;

Console.WriteLine($"The length of the circle is {pi}");
//DateTime dateTime = new DateTime.Now;

DateTime dateTime1 = new DateTime(2024, 01, 01);
DateTime dateTime2 = new DateTime(2023, 01, 01);
var difference = dateTime1.Subtract(DateTime.Now).Days;
var difference1 = DateTime.Now.Subtract(dateTime2).Days;

Console.WriteLine($"{difference} days left to New Year");
Console.WriteLine($"{difference1} days passed from New Year");