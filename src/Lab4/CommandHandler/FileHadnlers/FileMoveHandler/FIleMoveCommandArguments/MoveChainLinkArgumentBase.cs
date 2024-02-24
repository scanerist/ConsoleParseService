using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler.FIleMoveCommandArguments;

public abstract class MoveChainLinkArgumentBase : IMoveChainLinkArgument
{
    public IMoveChainLinkArgument? Next { get; protected set; }

    public void AddNext(IMoveChainLinkArgument? link)
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

    public abstract CommandResult Handle(Request request, IFileMoveBuilder builder);
}