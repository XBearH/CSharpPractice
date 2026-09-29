// See https://aka.ms/new-console-template for more information

// Task03: Grade Determination

Console.WriteLine("Enter your score (0-100):");

string inputScore = Console.ReadLine()!;
if(int.TryParse(inputScore, out int score))
{
    if(score < 0 || score > 100)
    {
        Console.WriteLine("Invalid input. Please enter a score between 0 and 100.");
    }
    else
    {
        char grade;
        if(score >= 90)
        {
            grade = 'A';
        }
        else if(score >= 80)
        {
            grade = 'B';
        }
        else if(score >= 70)
        {
            grade = 'C';
        }
        else if(score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'E';
        }
        Console.WriteLine($"Your grade is: {grade}.");
    }
}