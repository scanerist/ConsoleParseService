using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler.FileRenameArguments;

public class RenamePathHandler : RenameChainLinkArgumentBase
{
    public override CommandResult Handle(Request request, IFileRenameBuilder builder)
    {
        builder.AddPath(new Path(request.Value));
        return new CommandResult.SuccessResult(builder.Build());
    }
}