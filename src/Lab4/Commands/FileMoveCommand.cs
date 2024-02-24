namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileMoveCommand : ICommand
{
    private IPath _path;

    public FileMoveCommand(IPath path)
    {
        _path = path;
    }

    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}