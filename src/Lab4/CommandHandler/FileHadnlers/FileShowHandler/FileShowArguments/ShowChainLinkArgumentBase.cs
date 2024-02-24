using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler.FileShowArguments;

public abstract class ShowChainLinkArgumentBase : IShowChainLinkArgument
{
    public IShowChainLinkArgument? Next { get; protected set; }

    public void AddNext(IShowChainLinkArgument? link)
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

    public abstract CommandResult Handle(Request request, IFileShowBuilder builder);
}