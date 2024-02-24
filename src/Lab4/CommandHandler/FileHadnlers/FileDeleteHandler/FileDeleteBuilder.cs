using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileDeleteHandler;

public class FileDeleteBuilder : IFileDeleteBuilder
{
    private IPath? _path;

    public FileDeleteCommand Build()
    {
        return new FileDeleteCommand(_path ?? throw new ArgumentNullException(nameof(_path)));
    }

    public void AddPath(IPath path)
    {
        _path = path;
    }
}