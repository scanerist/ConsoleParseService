using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler.FileRenameArguments;

public abstract class RenameChainLinkArgumentBase : IRenameChainLinkArgument
{
    public IRenameChainLinkArgument? Next { get; protected set; }

    public void AddNext(IRenameChainLinkArgument? link)
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

    public abstract CommandResult Handle(Request request, IFileRenameBuilder builder);
}