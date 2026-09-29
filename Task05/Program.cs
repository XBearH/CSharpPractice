// See https://aka.ms/new-console-template for more information

// Task05: sum from 1 to n

Console.WriteLine("Enter a positive integer n  to calculate sum from 1 to n:");
string input = Console.ReadLine()!;
int n = int.Parse(input);
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
 Console.WriteLine($"Sum from 1 to {n} is:{sum}. ");