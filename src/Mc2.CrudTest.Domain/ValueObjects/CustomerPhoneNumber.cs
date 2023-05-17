using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerPhoneNumber
{
    public string Value { get; }

    public CustomerPhoneNumber(string value)
    {

        if (IsValidNumber(value) is false)
        {
            throw new InvalidCustomerPhoneNumberException();
        }
        Value = value;
    }

    private bool IsValidNumber(string number) =>
        PhoneNumbers.PhoneNumberUtil.GetInstance().IsPossibleNumber(number, "");

    public static implicit operator string(CustomerPhoneNumber id)
      => id.Value;

    public static implicit operator CustomerPhoneNumber(string id)
        => new(id);
}