using Lightweight.Kit.Validation.Extensions;

namespace Lightweight.Kit.UnitTests.Thrower;

public class BooleanThrowExtensionsTests
{
    [Test]
    public void ThrowIfNull_WhenValueIsNull_ShouldThrow()
    {
        bool? value = null;

        TestDelegate action = () => value.ThrowIfNull();

        Assert.Throws<ArgumentNullException>(action);
    }

    [Test]
    public void ThrowIfTrue_WhenValueIsFalse_ShouldNotThrow()
    {
        const bool value = false;

        TestDelegate action = () => value.ThrowIfTrue();

        Assert.DoesNotThrow(action);
    }
}