using SimpleCQRSApp.Abstractions;


namespace SimpleCQRSApp.Endpoints.AddFruit
{
    public sealed record AddFruitCommand(string Fruit) : ICommand<string>;
}
