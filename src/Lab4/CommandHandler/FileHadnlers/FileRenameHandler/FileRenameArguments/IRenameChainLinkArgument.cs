using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler.FileRenameArguments;

public interface IRenameChainLinkArgument
{
    void AddNext(IRenameChainLinkArgument? link);
    CommandResult Handle(Request request, IFileRenameBuilder builder);
}