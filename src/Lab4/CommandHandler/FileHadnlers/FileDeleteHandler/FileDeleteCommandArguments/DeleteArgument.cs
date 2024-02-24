using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler.FileDeleteCommandArguments;

public class DeleteArgument : DeleteChainLinkArgumentBase
{
    public override CommandResult Handle(Request request, IFileDeleteBuilder builder)
    {
        builder.AddPath(new Path(request.Value));
        Executor.Execute(builder.Build());
        return new CommandResult.SuccessResult(builder.Build());
    }
}