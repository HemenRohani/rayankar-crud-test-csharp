using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerEmail
{
    public string Value { get; }

    public CustomerEmail(string value)
    {
        Value = value;
    }

    public static implicit operator string(CustomerEmail email)
      => email.Value;

    public static implicit operator CustomerEmail(string email)
        => new(email);
}