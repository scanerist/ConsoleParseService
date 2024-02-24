namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class ConnectCommand : ICommand
{
    private IPath _path;

    public ConnectCommand(IPath path)
    {
        _path = path;
    }

    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}