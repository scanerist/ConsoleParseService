using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler.ConnectArguments;

public abstract class ConnectChainLinkArgumentBase : IConnectChainLinkArgument
{
    public IConnectChainLinkArgument? Next { get; protected set; }

    public void AddNext(IConnectChainLinkArgument? link)
    {
        if (Next is null)
        {
            Next = link;
        }
        else
        {
            Next.AddNext(link);
        }
    }

    public abstract CommandResult Handle(Request request, IConnectBuilder builder);
}