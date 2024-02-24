using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler;

public interface IChainLinkFileMove
{
    void AddNext(IChainLinkFileMove? link);
    CommandResult Handle(Request request);
}