// See https://aka.ms/new-console-template for more 

//Task00: 'Hello' and Input

/*
Console.WriteLine("Welcome to study C#!");
Console.WriteLine("May I know your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"OK, {name}, how old are you?");
string age = Console.ReadLine();
if(age == "1")
{
    Console.WriteLine($"{name}, you are one year old!");
}
else
{
    Console.WriteLine($"You are {age} years old, {name}!");
}
*/
Console.WriteLine("Who are you and how old are you?");
string name = Console.ReadLine();
string age = Console.ReadLine();
if(age == "1")
{
    Console.WriteLine($"{name}, you are one year old!");
}
else
{
    Console.WriteLine($"You are {age} years old, {name}!");
}