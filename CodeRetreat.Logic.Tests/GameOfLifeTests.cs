using System.Collections;

namespace CodeRetreat.Logic.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        private static readonly bool[,] EmptyGrid = new bool[0, 0];

        private static readonly bool[,] Grid =
        {
            { false, false, false, false, false },
            { false, true, true, true, false },
            { false, false, true, true, false },
            { false, true, false, true, false },
            { false, false, false, false, false }
        };

        private static readonly bool[,] GridResult =
        {
            { false, false, true, false, false },
            { false, true, false, true, false },
            { false, true, false, false, true },
            { false, false, false, true, false },
            { false, false, false, false, false }
        };

        [Test]
        public void CreateNextGeneration_EmptyGrid_ReturnsEmptyGrid()
        {
            var result = GameOfLife.CreateNextGeneration(EmptyGrid);

            Assert.That(StructuralComparisons.StructuralEqualityComparer.Equals(EmptyGrid, result), Is.True);
        }

        [Test]
        public void CreateNextGeneration_Grid_ReturnsGridResult()
        {
            var result = GameOfLife.CreateNextGeneration(Grid);

            Assert.AreEqual(string.Join(",", GridResult), string.Join(",", result));
        }
    }
}