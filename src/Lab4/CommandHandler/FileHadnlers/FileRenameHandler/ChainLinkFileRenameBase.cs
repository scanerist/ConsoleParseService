using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler;

public abstract class ChainLinkFileRenameBase : IChainLinkFileRename
{
    public IChainLinkFileRename? Next { get; protected set; }

    public void AddNext(IChainLinkFileRename? link)
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