using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler;

public abstract class ChainLinkFileMoveBase : IChainLinkFileMove
{
    public IChainLinkFileMove? Next { get; protected set; }

    public void AddNext(IChainLinkFileMove? link)
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