using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;

public abstract class ChainLinkFileShowBase : IChainLinkFileShow
{
    public IChainLinkFileShow? Next { get; protected set; }

    public void AddNext(IChainLinkFileShow? link)
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