using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Executor
{
    public static void Execute(ICommand command)
    {
        command.Execute();
    }
}