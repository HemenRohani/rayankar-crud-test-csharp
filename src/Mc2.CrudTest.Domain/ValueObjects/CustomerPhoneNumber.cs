using Mc2.CrudTest.Domain.Exception;
using PhoneNumbers;

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

    private bool IsValidNumber(string number)
    {
        var phoneNumber = PhoneNumbers.PhoneNumberUtil.GetInstance().Parse(number,"IR");

        return PhoneNumbers.PhoneNumberUtil.GetInstance().IsPossibleNumberForType(phoneNumber, PhoneNumberType.MOBILE) &&
            PhoneNumbers.PhoneNumberUtil.GetInstance().GetNumberType(phoneNumber) != PhoneNumberType.FIXED_LINE;
    }

    public static implicit operator string(CustomerPhoneNumber id)
      => id.Value;

    public static implicit operator CustomerPhoneNumber(string id)
        => new(id);
}