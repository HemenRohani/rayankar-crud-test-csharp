using System;
using Mc2.CrudTest.Domain.Exception;
namespace Mc2.CrudTest.Domain.ValueObjects;
public record CustomerDateOfBirth
{
    public DateOnly Value { get; }

    public CustomerDateOfBirth(DateOnly value)
    {
        Value = value;
    }

    public static implicit operator DateOnly(CustomerDateOfBirth dateOfBirth)
      => dateOfBirth.Value;

    public static implicit operator CustomerDateOfBirth(DateOnly dateOfBirth)
        => new(dateOfBirth);
}