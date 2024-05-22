using System.Collections;

namespace CodeRetreat.Logic.Tests;

[TestFixture]
public class GameOfLifeTests
{
    private static readonly bool[,] EmptyGrid = new bool[0, 0];

    private static readonly bool[,] Grid1 =
    {
        { true, true, true, true, true },
        { true, false, false, false, true },
        { true, true, false, false, true },
        { true, false, true, false, true },
        { true, true, true, true, true }
    };

    private static readonly bool[,] Grid1Result =
    {
        { true, true, true, true, true },
        { true, false, false, false, true },
        { true, true, false, false, true },
        { true, true, true, false, true },
        { true, true, true, true, true }
    };

    [Test]
    public void GetGetNextGeneration_EmptyGrid_ReturnsEmptyGrid()
    {
        var result = GameOfLife.GetNextGeneration(EmptyGrid);

        Assert.That(StructuralComparisons.StructuralEqualityComparer.Equals(EmptyGrid, result), Is.True);
    }
}