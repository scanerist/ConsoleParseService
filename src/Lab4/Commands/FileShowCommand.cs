namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileShowCommand : ICommand
{
    private IPath _path;

    public FileShowCommand(IPath path)
    {
        _path = path;
    }

    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}