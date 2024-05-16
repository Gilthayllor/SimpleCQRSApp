namespace SimpleCQRSApp.Shared
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string Error { get; set; }

        protected Result(bool isSuccess, string error)
        {
            IsSuccess = isSuccess; 
            Error = error;
        }

        public static Result Success() => new Result(true, string.Empty);
        public static Result Failure(string error) => new Result(false, error);
        public static Result<T> Success<T>(T value) => new(value, true, string.Empty);
        public static Result<T> Failure<T>(string error) => new(default, false, error);
        public static Result<T> Create<T>(T? value) => value is not null ? Success(value) : Failure<T>("Null value");
    }

    public class Result<T> : Result
    {
        private T? _value;
        protected internal Result(T? value, bool isSuccess, string error) : base(isSuccess, error)
        {
            _value = value;
        }

        public T Value => IsSuccess ? _value! : throw new InvalidOperationException("Não é possível obter o valor de resultado com falha.");

        public static implicit operator Result<T>(T? value) => Create(value);
    }
}
