using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerLastname
{
    public string Value { get; }

    public CustomerLastname(string value)
    {
        Value = value;
    }

    public static implicit operator string(CustomerLastname lastname)
      => lastname.Value;

    public static implicit operator CustomerLastname(string lastname)
        => new(lastname);
}