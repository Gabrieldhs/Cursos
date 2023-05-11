namespace mp.component.domain.Validations
{
    public class DomainValidationsException : Exception
    {
        public DomainValidationsException(string error) : base(error) 
        { }

        public static void When(bool hasError, string message)
        {
            if(hasError)
                throw new DomainValidationsException(message);
        }

    }
}
