using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandResults;

public abstract record CommandResult
{
    private CommandResult() { }
    public record UnknownResult() : CommandResult;
    public record SuccessResult(ICommand Command) : CommandResult;
}