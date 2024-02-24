using Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler.FileShowArguments;

public interface IShowChainLinkArgument
{
    void AddNext(IShowChainLinkArgument? link);
    CommandResult Handle(Request request, IFileShowBuilder builder);
}