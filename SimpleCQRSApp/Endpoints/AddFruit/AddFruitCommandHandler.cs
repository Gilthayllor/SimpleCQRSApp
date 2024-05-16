using SimpleCQRSApp.Abstractions;
using SimpleCQRSApp.Shared;

namespace SimpleCQRSApp.Endpoints.AddFruit
{
    public class AddFruitCommandHandler : ICommandHandler<AddFruitCommand, string>
    {
        private readonly FruitService _fruitService;

        public AddFruitCommandHandler(FruitService fruitService)
        {
            _fruitService = fruitService;
        }

        public Task<Result<string>> Handle(AddFruitCommand request, CancellationToken cancellationToken)
        {
            _fruitService.AddFruit(request.Fruit);

            return Task.FromResult(Result<string>.Success("Fruta adicionada com sucesso!"));
        }
    }
}
