// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

Console.ForegroundColor = ConsoleColor.DarkRed;


countdown(10);

static void countdown(int seconds)
{

    while (seconds >= 0)
    {

        Console.WriteLine(seconds.ToString());

        seconds -= 1;

        Thread.Sleep(1000);

    }

    Console.WriteLine("Blast off!");
}               

