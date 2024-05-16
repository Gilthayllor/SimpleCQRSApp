namespace SimpleCQRSApp.Endpoints
{
    public static class FruitsEndpoints
    {

        public IEndpointRouteBuilder MapFruitEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet();
        }
    }
}
