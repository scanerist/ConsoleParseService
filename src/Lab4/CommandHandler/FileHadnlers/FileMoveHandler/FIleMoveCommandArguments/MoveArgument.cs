using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler.FIleMoveCommandArguments;

public class MoveArgument : MoveChainLinkArgumentBase
{
    public override CommandResult Handle(Request request, IFileMoveBuilder builder)
    {
        builder.AddPath(new Path(request.Value));
        Executor.Execute(builder.Build());
        return new CommandResult.SuccessResult(builder.Build());
    }
}