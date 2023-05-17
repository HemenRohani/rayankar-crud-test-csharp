using System;
using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerDateOfBirth
{
    public DateTime Value { get; }

    public CustomerDateOfBirth(DateTime value)
    {
        Value = value;
    }

    public static implicit operator DateTime(CustomerDateOfBirth dateOfBirth)
      => dateOfBirth.Value;

    public static implicit operator CustomerDateOfBirth(DateTime dateOfBirth)
        => new(dateOfBirth);
}