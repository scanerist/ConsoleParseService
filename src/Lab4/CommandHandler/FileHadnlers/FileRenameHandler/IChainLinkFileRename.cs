using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler;

public interface IChainLinkFileRename
{
    void AddNext(IChainLinkFileRename? link);
    CommandResult Handle(Request request);
}