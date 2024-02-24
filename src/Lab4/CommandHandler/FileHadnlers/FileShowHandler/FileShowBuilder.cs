using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileShowHandler;

public class FileShowBuilder : IFileShowBuilder
{
    private IPath? _path;

    public void AddPath(IPath path)
    {
        _path = path;
    }

    public FileShowCommand Build()
    {
        return new FileShowCommand(_path ?? throw new ArgumentNullException(nameof(_path)));
    }
}