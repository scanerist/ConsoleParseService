using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandHandler.ConnectCommandHandler;

public interface IConnectBuilder
{
    ConnectCommand Build();
    void AddPath(IPath path);
}