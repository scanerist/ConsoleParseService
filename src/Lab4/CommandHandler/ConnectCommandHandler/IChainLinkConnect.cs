using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler;

public interface IChainLinkConnect
{
    void AddNext(IChainLinkConnect? link);
    CommandResult Handle(Request request);
}