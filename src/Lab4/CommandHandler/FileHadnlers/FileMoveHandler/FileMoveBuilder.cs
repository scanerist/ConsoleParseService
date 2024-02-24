using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileMoveHandler;

public class FileMoveBuilder : IFileMoveBuilder
{
    private IPath? _path;

    public FileMoveCommand Build()
    {
        return new FileMoveCommand(_path ?? throw new ArgumentNullException(nameof(_path)));
    }

    public void AddPath(IPath path)
    {
        _path = path;
    }
}