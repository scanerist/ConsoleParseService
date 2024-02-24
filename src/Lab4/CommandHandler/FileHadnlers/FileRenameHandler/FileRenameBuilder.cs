using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.FileHadnlers.FileRenameHandler;

public class FileRenameBuilder : IFileRenameBuilder
{
    private IPath? _path;
    private Name? _name;

    public FileRenameCommand Build()
    {
        return new FileRenameCommand(
            _path ?? throw new ArgumentNullException(nameof(_path)),
            _name ?? throw new ArgumentNullException(nameof(_name)));
    }

    public void AddName(Name name)
    {
        _name = name;
    }

    public void AddPath(IPath path)
    {
        _path = path;
    }
}