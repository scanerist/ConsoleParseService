using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler.FileDeleteCommandArguments;

public interface IDeleteChainLinkArgument
{
    void AddNext(IDeleteChainLinkArgument? link);
    CommandResult Handle(Request request, IFileDeleteBuilder builder);
}