using FastTech.Domain.Core.Messages;

namespace FastTech.Core.Common.Mediatr;

public interface IMediatrHandler
{
    Task<bool>EnviarComando<T>(T comando) where T : Command;
}
