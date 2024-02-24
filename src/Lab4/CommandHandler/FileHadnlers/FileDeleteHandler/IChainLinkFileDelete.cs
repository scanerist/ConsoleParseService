using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler;

public interface IChainLinkFileDelete
{
    void AddNext(IChainLinkFileDelete? link);
    CommandResult Handle(Request request);
}