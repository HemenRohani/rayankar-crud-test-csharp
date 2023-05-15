namespace Mc2.CrudTest.Shared.Abstractions.Exceptions
{
    public abstract class CustomerException : Exception
    {
        protected CustomerException(string message) : base(message)
        {

        }
    }
}