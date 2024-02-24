using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;

public class FileShow : ChainLinkFileShowBase
{
    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[1].Equals("show", StringComparison.Ordinal))
        {
            return Next?.Handle(request) ?? new CommandResult.UnknownResult();
        }

        return new CommandResult.UnknownResult();
    }
}