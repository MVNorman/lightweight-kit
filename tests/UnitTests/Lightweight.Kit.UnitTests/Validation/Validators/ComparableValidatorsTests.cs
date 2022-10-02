using Lightweight.Kit.Validation.Validators;

namespace Lightweight.Kit.UnitTests.Validation.Validators;

public class ComparableValidatorsTests
{
    [Test]
    public void ThrowIfNotInRange_WhenValueIsNotInRange_ShouldThrow()
    {
        const int min = 1;
        
        const int max = 10;
        
        const int value = 11;

        void Action() => value.ThrowIfNotInRange(min, max);

        Assert.Throws<ArgumentOutOfRangeException>(Action);
    }
    
    [Test]
    public void ThrowIfNotInRange_WhenValueIsInRange_ShouldNotThrow()
    {
        const int min = 1;
        
        const int max = 10;
        
        const int value = 9;

        void Action() => value.ThrowIfNotInRange(min, max);

        Assert.DoesNotThrow(Action);
    }
    
    [Test]
    public void ThrowIfNotInRange_DateTimeWhenValueIsNotInRange_ShouldThrow()
    {
        DateTime min = DateTime.Now.AddDays(-1);
        
        DateTime max = DateTime.Now.AddDays(10);
        
        DateTime value = DateTime.Now.AddDays(20);

        void Action() => value.ThrowIfNotInRange(min, max);

        Assert.Throws<ArgumentOutOfRangeException>(Action);
    }
    
    [Test]
    public void ThrowIfNotInRange_DateTimeWhenValueIsInRange_ShouldNotThrow()
    {
        DateTime min = DateTime.Now.AddDays(-1);
        
        DateTime max = DateTime.Now.AddDays(10);
        
        DateTime value = DateTime.Now;

        void Action() => value.ThrowIfNotInRange(min, max);

        Assert.DoesNotThrow(Action);
    }
}