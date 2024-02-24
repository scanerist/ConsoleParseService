using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler.ConnectArguments;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler;

public class Connect : ChainLinkBase
{
    public IConnectChainLinkArgument? NextArgument { get; protected set; } = new ConnectArgument();

    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[0].Equals("connect", StringComparison.Ordinal))
        {
            return NextArgument?.Handle(request, new ConnectBuilder()) ?? new CommandResult.UnknownResult();
        }

        return Next?.Handle(request) ?? new CommandResult.UnknownResult();
    }
}