using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler;

public class ConnectBuilder : IConnectBuilder
{
    private IPath? _path;
    public ConnectCommand Build()
    {
        return new ConnectCommand(_path ?? throw new ArgumentNullException(nameof(_path)));
    }

    public void AddPath(IPath path)
    {
        _path = path;
    }
}