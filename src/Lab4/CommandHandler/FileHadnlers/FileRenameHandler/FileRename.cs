using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler;

public class FileRename : ChainLinkBase
{
    private readonly IChainLink? _next;

    public FileRename(IChainLink? next)
    {
        _next = next;
    }

    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[1].Equals("rename", StringComparison.Ordinal))
        {
            return _next?.Handle(request) ?? new CommandResult.UnknownResult();
        }

        return new CommandResult.UnknownResult();
    }
}