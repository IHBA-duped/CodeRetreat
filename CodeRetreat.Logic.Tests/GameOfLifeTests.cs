namespace CodeRetreat.Logic.Tests
{
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

        [Test]
        public void Test1()
        {
        }
    }
}