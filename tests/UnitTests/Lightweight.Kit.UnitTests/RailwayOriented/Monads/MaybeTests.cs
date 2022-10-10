using Lightweight.Kit.RailwayOriented.DealingWithNoValue;
using Lightweight.Kit.RailwayOriented.Monads;

namespace Lightweight.Kit.UnitTests.RailwayOriented.Monads;

public class MaybeTests
{
    [Test]
    public void Maybe_WhenDefaultCtor_ShouldHaveNullValue()
    {
        string a = A();
        Maybe<string> b = B(1);

        var ktp = b.Value;
        
        Maybe<string> maybe = new();

        string value = maybe;

        Assert.That(value, Is.EqualTo(null));
    }

    public string A()
    {
        return null;
    }

    public Maybe<string> B(int input)
    {
        if (input == 1)
        {
            return null;
        }
        else
        {
            return "FF";
        }
    }
}