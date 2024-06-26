﻿using SimpleCQRSApp.Abstractions;
using SimpleCQRSApp.Shared;

namespace SimpleCQRSApp.Endpoints.GetFruits
{
    public class GetFruitsQueryHandler : IQueryHandler<GetFruitsQuery, FruitsResponse>
    {
        private FruitService _fruitService;

        public GetFruitsQueryHandler(FruitService fruitService)
        {
            _fruitService = fruitService;
        }

        public Task<Result<FruitsResponse>> Handle(GetFruitsQuery request, CancellationToken cancellationToken)
        {
            var fruitsResponse = new FruitsResponse([.. _fruitService.Fruits]);

            return Task.FromResult(Result<FruitsResponse>.Success(fruitsResponse));
        }
    }
}
