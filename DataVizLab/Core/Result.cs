namespace DataVizLab.Core
{
    public class Result<T> where T : notnull
    {
        private readonly T? value;
        private readonly string? error;
        private readonly bool success;

        private Result(T? value, string? error, bool success)
        {
            this.value = value;
            this.error = error;
            this.success = success;
        }

        public T Value
        {
            get
            {
                if (success) return value!;
                throw new InvalidOperationException("Result has no value.");
            }
        }

        public string Error
        {
            get
            {
                if (!success) return error!;
                throw new InvalidOperationException("Result has no error.");
            }
        }

        public bool IsSuccessful => success;

        public bool IsFailed => !success;

        public static Result<U> Success<U>(U value) where U : notnull => new(value, null, true);

        public static Result<U> Failure<U>(string error) where U : notnull => new(default, error, false);
    }
}
