using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers;

public class FileChainLink : IFileChainLink
{
    public IFileChainLink? Next { get; protected set; }

    public void AddNext(IFileChainLink? link)
    {
        if (Next is null)
        {
            Next = link;
        }
        else
        {
            Next.AddNext(link);
        }
    }

    public CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[0].Equals("file", StringComparison.Ordinal))
        {
            return Next?.Handle(request) ?? new CommandResult.UnknownResult();
        }

        return Next?.Handle(request) ?? new CommandResult.UnknownResult();
    }
}