using MediatR;
using SimpleCQRSApp.Shared;

namespace SimpleCQRSApp.Abstractions
{
    public interface IQueryHandler<TQuery, TReponse> : IRequestHandler<TQuery, Result<TReponse>>
        where TQuery : IQuery<TReponse>
    {
    }
}
