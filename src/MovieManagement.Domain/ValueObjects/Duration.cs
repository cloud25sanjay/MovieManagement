using MovieManagement.Domain.Exceptions;


namespace MovieManagement.Domain.ValueObjects
{
    public sealed class Duration
    {
        public int Minutes { get; private set; }

        public Duration(int minutes)
        {
            if (minutes <= 0)
            {
                throw new DomainException("Duration must be greater than 0");
            }

            if(minutes > 600)
            {
                throw new DomainException("Duration Cannot exceed 600 minutes");
            }

            Minutes = minutes;
        }

        public override string ToString()
        {
            return $"{Minutes} minutes";
        }
    }
}
