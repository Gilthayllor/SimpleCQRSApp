namespace SimpleCQRSApp
{
    public class FruitService
    {
        private List<string> _fruits = new List<string>();
        public IReadOnlyCollection<string> Fruits => _fruits;

        public FruitService()
        {
            _fruits = [
                "Apple",
                "Banana",
                "Orange",
                "Strawberry",
                "Grape"
            ];
        }

        public void AddFruit(string fruit)
        {
            _fruits.Add(fruit);
        }
    }
}
