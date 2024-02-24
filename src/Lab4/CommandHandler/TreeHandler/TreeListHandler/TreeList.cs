using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.TreeHandler.TreeListHandler;

public class TreeList : ChainLinkBase
{
    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[1].Equals("list", StringComparison.Ordinal))
        {
            return new CommandResult.UnknownResult();
        }

        return Next?.Handle(request) ?? new CommandResult.UnknownResult();
    }
}