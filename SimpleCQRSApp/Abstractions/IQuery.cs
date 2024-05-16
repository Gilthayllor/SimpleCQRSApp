using MediatR;
using SimpleCQRSApp.Shared;

namespace SimpleCQRSApp.Abstractions
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
