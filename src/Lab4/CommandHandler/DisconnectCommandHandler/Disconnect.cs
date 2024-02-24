using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.DisconnectCommandHandler;

public class Disconnect : ChainLinkBase
{
    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[0].Equals("disconnect", StringComparison.Ordinal))
        {
            return new CommandResult.SuccessResult(new DisconnectCommand());
        }

        return Next?.Handle(request) ?? new CommandResult.UnknownResult();
    }
}