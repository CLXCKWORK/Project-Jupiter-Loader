using System.Diagnostics;
using System;
using System.Net;
using System.Reflection.Metadata;
using System.IO;
//Font color
Console.ForegroundColor = ConsoleColor.Yellow;    
// ASCII
Console.WriteLine("██████╗ ██████╗  ██████╗      ██╗███████╗ ██████╗████████╗         ██╗██╗   ██╗██████╗ ██╗████████╗███████╗██████╗     ██╗   ██╗ ██╗    ██████╗     ");
Console.WriteLine("██╔══██╗██╔══██╗██╔═══██╗     ██║██╔════╝██╔════╝╚══██╔══╝         ██║██║   ██║██╔══██╗██║╚══██╔══╝██╔════╝██╔══██╗    ██║   ██║███║   ██╔═████╗    ");
Console.WriteLine("██████╔╝██████╔╝██║   ██║     ██║█████╗  ██║        ██║            ██║██║   ██║██████╔╝██║   ██║   █████╗  ██████╔╝    ██║   ██║╚██║   ██║██╔██║    ");
Console.WriteLine("██╔═══╝ ██╔══██╗██║   ██║██   ██║██╔══╝  ██║        ██║       ██   ██║██║   ██║██╔═══╝ ██║   ██║   ██╔══╝  ██╔══██╗    ╚██╗ ██╔╝ ██║   ████╔╝██║    ");
Console.WriteLine("██║     ██║  ██║╚██████╔╝╚█████╔╝███████╗╚██████╗   ██║       ╚█████╔╝╚██████╔╝██║     ██║   ██║   ███████╗██║  ██║     ╚████╔╝  ██║██╗╚██████╔╝    ");
Console.WriteLine("╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚════╝ ╚══════╝ ╚═════╝   ╚═╝        ╚════╝  ╚═════╝ ╚═╝     ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝      ╚═══╝   ╚═╝╚═╝ ╚═════╝     ");
Console.WriteLine("██╗      ██████╗  █████╗ ██████╗ ███████╗██████╗              ███╗   ███╗██╗████████╗██╗   ██╗ ██╗ ██╗  ██████╗  ██████╗  ██████╗  ██╗              ");
Console.WriteLine("██║     ██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗             ████╗ ████║██║╚══██╔══╝██║   ██║████████╗██╔═████╗██╔═████╗██╔═████╗███║              ");
Console.WriteLine("██║     ██║   ██║███████║██║  ██║█████╗  ██████╔╝             ██╔████╔██║██║   ██║   ██║   ██║╚██╔═██╔╝██║██╔██║██║██╔██║██║██╔██║╚██║              ");
Console.WriteLine("██║     ██║   ██║██╔══██║██║  ██║██╔══╝  ██╔══██╗             ██║╚██╔╝██║██║   ██║   ██║   ██║████████╗████╔╝██║████╔╝██║████╔╝██║ ██║              ");
Console.WriteLine("███████╗╚██████╔╝██║  ██║██████╔╝███████╗██║  ██║██╗██╗██╗    ██║ ╚═╝ ██║██║   ██║   ╚██████╔╝╚██╔═██╔╝╚██████╔╝╚██████╔╝╚██████╔╝ ██║              ");
Console.WriteLine("╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝╚═╝╚═╝    ╚═╝     ╚═╝╚═╝   ╚═╝    ╚═════╝  ╚═╝ ╚═╝  ╚═════╝  ╚═════╝  ╚═════╝  ╚═╝              ");
Thread.Sleep(3000); // Sleeps
//Whitelist
string whitelist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/GzN3LqkD");
//Blacklist
string blacklist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/FnQPkB6P");

//C# Print
Console.WriteLine("Sharing this key allows people to login to your account wich will get your account blacklisted from our system.");
Console.WriteLine("Key:");
string data = Console.ReadLine();

// Only works if "string whitelist" is still a thing
if (whitelist.Contains(data))
{
    Console.WriteLine("Whitelisted!");
    Console.Clear();
}
else
{
    Console.WriteLine("Blacklisted! Click enter to close...");
}

// Only works if "blacklist whitelist" is still a thing
if (blacklist.Contains(data))
{
    Console.WriteLine("Blacklisted! Click enter to close...");
}

// Only works if "string whitelist" is still a thing
if (whitelist.Contains(data))
{
    Console.WriteLine("Whitelisted - Click enter to go to the injector <3");
    Console.ReadKey();
}
// Only works if "string whitelist" is still a thing

if (whitelist.Contains(data))
{
    Console.WriteLine("Loader api down contact staff or admin.");
}

//Pauses or when they click enter it closes
Console.ReadLine();