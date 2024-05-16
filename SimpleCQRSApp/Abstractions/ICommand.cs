using MediatR;
using SimpleCQRSApp.Shared;

namespace SimpleCQRSApp.Abstractions
{
    public interface ICommand : IRequest<Result>
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
