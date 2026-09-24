// See https://aka.ms/new-console-template for more information

//Task01: Calculator with two numbers

Console.WriteLine("Enter first number:");
string input1 = Console.ReadLine()!;
double num1 = double.Parse(input1);

Console.WriteLine("Enter second number:");
string input2 = Console.ReadLine()!;
double num2 = double.Parse(input2);

double sum = num1 + num2;
double difference = num1 - num2;
double product = num1 * num2;

Console.WriteLine($"\nCalculation Results:");
Console.WriteLine($"{num1} + {num2} = {sum}");
Console.WriteLine($"{num1} - {num2} = {difference}");
Console.WriteLine($"{num1} * {num2} = {product}");

if (num2 != 0)
{
    double quotient = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {quotient}");
}
else
{
    Console.WriteLine("Division by zero is not allowed.");
}