using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;
namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.TreeHandler;

public class TreeCommandHandler : ChainLinkBase
{
    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[0].Equals("tree", StringComparison.Ordinal))
        {
            return new CommandResult.UnknownResult();
        }

        return new CommandResult.UnknownResult();
    }
}