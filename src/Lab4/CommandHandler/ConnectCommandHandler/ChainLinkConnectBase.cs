using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler;

public abstract class ChainLinkConnectBase : IChainLinkConnect
{
    public IChainLinkConnect? Next { get; protected set; }
    public void AddNext(IChainLinkConnect? link)
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

    public abstract CommandResult Handle(Request request);
}