using MovieManagement.Domain.Exceptions;

namespace MovieManagement.Domain.ValueObjects
{
    public sealed class Synopsis
    {
        public string Value { get; private set; }

        public Synopsis(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DomainException("Synopsis cannot be empty");
            }

            if(value.Length > 2000)
            {
                throw new DomainException("Synopsis cannot be exceed 2000 Characters");
            }

            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
