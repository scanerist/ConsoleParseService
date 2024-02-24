using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler.FIleMoveCommandArguments;

public interface IMoveChainLinkArgument
{
    void AddNext(IMoveChainLinkArgument? link);
    CommandResult Handle(Request request, IFileMoveBuilder builder);
}