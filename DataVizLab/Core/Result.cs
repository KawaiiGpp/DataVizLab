namespace DataVizLab.Core
{
    public class Result<T> where T : notnull
    {
        private readonly T? value;
        private readonly string? failureMessage;

        private Result(T? value, string? failureMessage)
        {
            this.value = value;
            this.failureMessage = failureMessage;
        }

        public T Value
        {
            get
            {
                if (value != null) return value;
                throw new InvalidOperationException("Result has no value.");
            }
        }

        public string FailureMessage
        {
            get
            {
                if (failureMessage != null) return failureMessage;
                throw new InvalidOperationException("Result has no message.");
            }
        }

        public bool IsSuccess => value != null;
        public bool IsFailure => failureMessage != null;

        // factory methods.
    }
}
