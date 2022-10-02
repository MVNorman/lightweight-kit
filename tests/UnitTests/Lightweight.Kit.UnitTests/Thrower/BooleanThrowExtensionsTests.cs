using Lightweight.Kit.Validation.Extensions;

namespace Lightweight.Kit.UnitTests.Thrower;

public class BooleanThrowExtensionsTests
{
    [Test]
    public void ThrowIfTrue_WhenValueIsTrue_ShouldThrow()
    {
        const bool value = true;

        void Action() => value.ThrowIfTrue();

        Assert.Throws<ArgumentException>(Action);
    }

    [Test]
    public void ThrowIfTrue_WhenValueIsFalse_ShouldNotThrow()
    {
        const bool value = false;

        void Action() => value.ThrowIfTrue();

        Assert.DoesNotThrow(Action);
    }
}