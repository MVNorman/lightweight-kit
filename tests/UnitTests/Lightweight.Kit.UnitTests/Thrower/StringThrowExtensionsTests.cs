using Lightweight.Kit.Validation.Extensions;

namespace Lightweight.Kit.UnitTests.Thrower;

public class StringThrowExtensionsTests
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