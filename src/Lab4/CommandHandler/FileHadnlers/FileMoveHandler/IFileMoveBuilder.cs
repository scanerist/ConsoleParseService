using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler;

public interface IFileMoveBuilder
{
    FileMoveCommand Build();
    void AddPath(IPath path);
}