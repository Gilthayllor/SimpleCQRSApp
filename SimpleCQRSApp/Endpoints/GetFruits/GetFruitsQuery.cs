using SimpleCQRSApp.Abstractions;

namespace SimpleCQRSApp.Endpoints.GetFruits
{
    public sealed record GetFruitsQuery : IQuery<FruitsResponse>;
}
