using Lightweight.Kit.Validation.Extensions;

namespace Lightweight.Kit.UnitTests.Thrower;

public class GenericThrowExtensionsTests
{
    [Test]
    public void ThrowIfNull_WhenValueIsNull_ShouldThrow()
    {
        bool? value = null;

        void Action() => value.ThrowIfNull();

        Assert.Throws<ArgumentNullException>(Action);
    }

    [Test]
    public void ThrowIfNull_WhenValueIsNotNull_ShouldNotThrow()
    {
        const bool value = false;

        void Action() => value.ThrowIfNull();

        Assert.DoesNotThrow(Action);
    }
}