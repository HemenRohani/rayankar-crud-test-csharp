using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerBankAccountNumber
{
    public string Value { get; }

    public CustomerBankAccountNumber(string value)
    {
        Value = value;
    }

    public static implicit operator string(CustomerBankAccountNumber bankAccountNumber)
      => bankAccountNumber.Value;

    public static implicit operator CustomerBankAccountNumber(string bankAccountNumber)
        => new(bankAccountNumber);
}