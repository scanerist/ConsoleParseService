using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler;

public interface IChainLink
{
    void AddNext(IChainLink? link);
    CommandResult Handle(Request request);
}