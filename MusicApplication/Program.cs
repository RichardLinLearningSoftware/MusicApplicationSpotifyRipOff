Console.WriteLine("Welcome to Spotify ripoff. Write 'help' for commands");

while( true )
{
    string command = Console.ReadLine().ToString();

    if(command == "help")
    {
        Console.WriteLine("yeah");
    }
    else
    {
        Console.WriteLine("Command '" + command+"' is not a command or misspelled");
    }
}