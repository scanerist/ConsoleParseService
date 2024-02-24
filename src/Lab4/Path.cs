namespace Itmo.ObjectOrientedProgramming.Lab4;

public class Path : IPath
{
    public Path(string path)
    {
        PathName = path;
    }

    public string PathName { get; }
}