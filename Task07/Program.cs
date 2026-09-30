// See https://aka.ms/new-console-template for more information

// Task07  Multiplication Table

for(int i = 1; i <= 9; i ++ )
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write($"{i} * {j} = {i * j}\t");
    }
    Console.WriteLine();
}