using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler.FileDeleteCommandArguments;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler;

public class FileDelete : ChainLinkFileDeleteBase
{
    public IDeleteChainLinkArgument? NextArgument { get; protected set; } = new DeleteArgument();
    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[1].Equals("delete", StringComparison.Ordinal))
        {
            return NextArgument?.Handle(request, new FileDeleteBuilder()) ?? new CommandResult.UnknownResult();
        }

        return Next?.Handle(request) ?? new CommandResult.UnknownResult();
    }
}