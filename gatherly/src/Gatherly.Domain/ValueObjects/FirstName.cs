using Gatherly.Domain.Premitives;
using Gatherly.Domain.Shared;

namespace Gatherly.Domain.ValueObjects;

public sealed class FirstName : ValueObject
{
    private FirstName(string value)
    {
        Value = value;
    }

    private const int MaxLength = 50;

    public static Result<FirstName> Create(string firstName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            return Result.Failure<FirstName>(new Error(
                "FirstName.Empty",
                "First name is empty."));
        }
        
        if (firstName.Length > MaxLength)
        {
            return Result.Failure<FirstName>(new Error(
                "FirstName.TooLong",
                "First name is too long."));
        }
        
        return new FirstName(firstName);
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
    
    private string Value { get; }
}