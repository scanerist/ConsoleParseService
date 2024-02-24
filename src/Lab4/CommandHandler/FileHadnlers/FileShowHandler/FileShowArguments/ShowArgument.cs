using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler.FileShowArguments;

public class ShowArgument : ShowChainLinkArgumentBase
{
    public override CommandResult Handle(Request request, IFileShowBuilder builder)
    {
        builder.AddPath(new Path(request.Value));
        return new CommandResult.SuccessResult(builder.Build());
    }
}