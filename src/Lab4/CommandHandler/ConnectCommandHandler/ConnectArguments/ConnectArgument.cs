using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler.ConnectArguments;

public class ConnectArgument : ConnectChainLinkArgumentBase
{
    public override CommandResult Handle(Request request, IConnectBuilder builder)
    {
        builder.AddPath(new Path(request.Value));
        Executor.Execute(builder.Build());
        return new CommandResult.SuccessResult(builder.Build());
    }
}