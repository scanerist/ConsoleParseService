using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler.FileRenameArguments;

public class RenameArgument : RenameChainLinkArgumentBase
{
    public override CommandResult Handle(Request request, IFileRenameBuilder builder)
    {
        builder.AddName(new Name(request.Value));
        return new CommandResult.SuccessResult(builder.Build());
    }
}