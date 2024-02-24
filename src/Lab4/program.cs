using System;
using Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers;
using Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        var connect = new File();
        Console.WriteLine(connect.ToString());
    }
}