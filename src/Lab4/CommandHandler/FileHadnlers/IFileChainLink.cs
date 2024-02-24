using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;

public interface IFileChainLink
{
    void AddNext(IFileChainLink? link);
    CommandResult Handle(Request request);
}