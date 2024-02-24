using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler;

public interface IFileDeleteBuilder
{
    void AddPath(IPath path);
    FileDeleteCommand Build();
}