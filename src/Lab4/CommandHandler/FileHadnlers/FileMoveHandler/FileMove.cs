using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler.FIleMoveCommandArguments;
using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler;

public class FileMove : ChainLinkFileMoveBase
{
    public IMoveChainLinkArgument? NextArgument { get; protected set; } = new MoveArgument();
    public override CommandResult Handle(Request request)
    {
        var comms = new List<string>(request.Value.Split(" "));
        if (comms[1].Equals("move", StringComparison.Ordinal))
        {
            return NextArgument?.Handle(request, new FileMoveBuilder()) ?? new CommandResult.UnknownResult();
        }

        return new CommandResult.UnknownResult();
    }
}