// See https://aka.ms/new-console-template for more information

// Task06 Guess the number

Console.WriteLine("Guess the number between 1 and 100.");
int number = new Random().Next(1, 101);
int guess = 0;
int count = 0;
while (guess != number)
{
    Console.Write("Please enter your guess: ");
    string input = Console.ReadLine()!;

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Invalid input! Please enter an integer.");
        continue;
    }

    // guess = int.TryParse(input);
    if(guess < number)
    {
        Console.WriteLine("Your guess is too low.");
    }
    else if(guess > number)
    {
        Console.WriteLine("Your guess is too high.");
    }
    else
    {
        Console.WriteLine("You guessed the number!");   
    }
    count ++;
}
Console.WriteLine("You guessed the number in " + count + " tries.");