using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerFirstname
{
    public string Value { get; }

    public CustomerFirstname(string value)
    {
        Value = value;
    }

    public static implicit operator string(CustomerFirstname firstname)
      => firstname.Value;

    public static implicit operator CustomerFirstname(string firstname)
        => new(firstname);
}