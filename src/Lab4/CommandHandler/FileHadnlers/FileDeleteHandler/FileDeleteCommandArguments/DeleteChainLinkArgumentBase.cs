using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler.FileDeleteCommandArguments;

public abstract class DeleteChainLinkArgumentBase : IDeleteChainLinkArgument
{
    public IDeleteChainLinkArgument? Next { get; set; }

    public void AddNext(IDeleteChainLinkArgument? link)
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

    public abstract CommandResult Handle(Request request, IFileDeleteBuilder builder);
}