using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler;

public abstract class ChainLinkFileDeleteBase : IChainLinkFileDelete
{
    public IChainLinkFileDelete? Next { get; protected set; }

    public void AddNext(IChainLinkFileDelete? link)
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