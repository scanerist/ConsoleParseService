namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileRenameCommand : ICommand
{
    private IPath _path;
    private Name _name;

    public FileRenameCommand(IPath path, Name name)
    {
        _path = path;
        _name = name;
    }

    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}