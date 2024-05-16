using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCQRSApp.Endpoints.AddFruit;
using SimpleCQRSApp.Endpoints.GetFruits;

namespace SimpleCQRSApp.Endpoints
{
    public static class FruitsEndpoints
    {
        public static IEndpointRouteBuilder MapFruitEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("GetFruits", async ([FromServices] ISender sender) =>
            {
                var result = await sender.Send(new GetFruitsQuery());

                return Results.Ok(result);
            });

            app.MapPost("AddNewFruit", async ([FromServices] ISender sender, [FromHeader] string FruitName) =>
            {
                var result = await sender.Send(new AddFruitCommand(FruitName));

                return Results.Ok(result);
            });

            return app;
        }
    }
}
