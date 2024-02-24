using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;

public interface IChainLinkFileShow
{
    void AddNext(IChainLinkFileShow? link);
    CommandResult Handle(Request request);
}