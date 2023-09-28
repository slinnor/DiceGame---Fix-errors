Random random = new();

double dice1 = random.Next(1, 6);
double dice2 = random.Next(1, 6);

if (dice1 == dice2)
{
    Console.WriteLine($"Endian! Dice 1: {dice1}, Dice 2: {dice2}");
}
else
    Console.WriteLine($"You throw dice1 + dice2 points!");
    if (dice1 + dice2 > 9)
    {
        ConsoleWriteLine("You throw a high numbers!!!");
        ConsoleWriteLine($"Dice 1: (dice), Dice 2: {dice2} => {dice1 + dice2}");
    }
    else (dice1 + dice2 > 4)
    {
        Console.WriteLine("You throw a medium numbers!");
        Console.WriteLine($"Dice 1: {dice1}, Dice 2: {dice2} => {dice1 + dice2}");
    }
    else
        Console.WriteLine("You throw a low numbers!")
        Console.WriteLine($"Dice 1: {dice1}, Dice 2: {dice2} => {dice1 + dice2}");
}