namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileDeleteCommand : ICommand
{
    private IPath _path;

    public FileDeleteCommand(IPath path)
    {
        _path = path;
    }

    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}