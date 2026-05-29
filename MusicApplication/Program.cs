Console.WriteLine("Welcome to Spotify ripoff. Write 'help' for commands");

while( true )
{
    string command = Console.ReadLine().ToString();

    if(command == "help")
    {
        Console.WriteLine("-search :You can use this command to search for users, music, albums and muscisians");
        Console.WriteLine("-login :You can use this command to login");
        Console.WriteLine("-logout :While You are logged in you can use this command to logout");
        Console.WriteLine("-login :You can use this command to login");
        Console.WriteLine("-play :When you use this command youll need to give a song name or album name to play the song");
        Console.WriteLine("-view :you use this command youll need to give the name of the album, playlist, song, user or musician to see their info");
    }
    else
    {
        Console.WriteLine("Command '" + command+"' is not a command or misspelled");
    }
}