using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler.ConnectArguments;

public interface IConnectChainLinkArgument
{
    void AddNext(IConnectChainLinkArgument? link);
    CommandResult Handle(Request request, IConnectBuilder builder);
}