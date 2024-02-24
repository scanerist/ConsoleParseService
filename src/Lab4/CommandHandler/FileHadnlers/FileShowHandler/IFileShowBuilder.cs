using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;

public interface IFileShowBuilder
{
    void AddPath(IPath path);
    FileShowCommand Build();
}