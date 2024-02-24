using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler;

public interface IFileRenameBuilder
{
    void AddPath(IPath path);
    void AddName(Name name);
    FileRenameCommand Build();
}