namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class UnknownCommand : ICommand
{
    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}