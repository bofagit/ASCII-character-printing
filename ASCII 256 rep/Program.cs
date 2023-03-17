int asciiValue;
int i = 0;
for (asciiValue = 0; asciiValue <= 128; asciiValue++)
{
    if ((i % 5) == 0)
    {
        Console.Write("\n");
    }
    Console.Write(" " + Convert.ToChar(asciiValue));
    i++;
}
Console.WriteLine("\n Press enter to exit...");
Console.ReadLine();