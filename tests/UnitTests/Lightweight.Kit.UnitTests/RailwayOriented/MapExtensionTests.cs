using Lightweight.Kit.RailwayOriented;
using Lightweight.Kit.RailwayOriented.Extensions;
using Lightweight.Kit.RailwayOriented.Monads;

namespace Lightweight.Kit.UnitTests.RailwayOriented;

public class MapExtensionTests
{
    [Test]
    public void Map_When_ShouldThrow()
    {
        int A() => 7;
        int B(int m) => m + 7;

        Func<int> a = AA;

        a.Map(x => x.Equals(1));
            
        Monad<int> result = Monad<int>
            .Create(A)
            .Map(B);

        if (result.Value == 14)
        {
            //Everything fine
        }
    }

    private int AA()
    {
        throw new NotImplementedException();
    }

    [Test]
    public void Bind_When_ShouldThrow()
    {
        int A() => 7;
        int B(int m) => m + 7;

        Monad<int> result = Monad<int>
            .Create(A)
            .Bind(x => new Monad<int>());

        if (result.IsSucceeded)
        {
        }
    }
}