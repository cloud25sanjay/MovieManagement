using MovieManagement.Domain.Exceptions;


namespace MovieManagement.Domain.ValueObjects
{
    public sealed class MovieTitle 
    {
        public string Value { get; private set; }

        public MovieTitle(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DomainException("Movie Title cannot be Empty");
            }

            if(value.Length > 200)
            {
                throw new DomainException("Movie Title cannot Exceed 200 characters");
            }

            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

    }
}
