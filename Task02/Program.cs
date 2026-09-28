// See https://aka.ms/new-console-template for more information

// Task02: Determine leap year

Console.WriteLine("Enter a year to check if it's a leap year:");
string inputYear = Console.ReadLine()!;
if(int.TryParse(inputYear, out int year))
{
    if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please input a valid year.");
}