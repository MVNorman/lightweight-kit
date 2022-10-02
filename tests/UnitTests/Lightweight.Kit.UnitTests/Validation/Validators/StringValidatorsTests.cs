using Lightweight.Kit.Validation.Validators;

namespace Lightweight.Kit.UnitTests.Validation.Validators;

public class StringValidatorsTests
{
    [Test]
    public void ThrowIfEmpty_WhenValueIsEmpty_ShouldThrow()
    {
        const string value = "";

        void Action() => value.ThrowIfEmpty();

        Assert.Throws<ArgumentException>(Action);
    }
    
    [Test]
    public void ThrowIfEmpty_WhenValueIsNotEmpty_ShouldNotThrow()
    {
        const string value = "take";

        void Action() => value.ThrowIfEmpty();

        Assert.DoesNotThrow(Action);
    }
}