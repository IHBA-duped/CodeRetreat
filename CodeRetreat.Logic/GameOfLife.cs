
namespace CodeRetreat.Logic
{
    public class GameOfLife
    {
        public static object CreateNextGeneration(bool[,] grid)
        {
            var height = grid.GetLength(0);
            var width = grid.GetLength(1);

            var result = new bool[height, width];

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    byte liveNeighbors = 0;
                    
                    // Calc living neighbors
                    if (LazyNeighborCheck(grid, i - 1, j - 1))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i - 1, j))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i - 1, j + 1))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i, j - 1))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i, j + 1))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i + 1, j - 1))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i + 1, j))
                        liveNeighbors++;
                    if (LazyNeighborCheck(grid, i + 1, j + 1))
                        liveNeighbors++;

                    //Apply rules
                    switch (liveNeighbors)
                    {
                        case 2:
                        case 3:
                            result[i, j] = true;
                            break;
                        default:
                            result[i, j] = false;
                            break;
                    }
                }
            }

            return result;
        }

        private static bool LazyNeighborCheck(bool[,] grid, int i, int j)
        {
            try
            {
                return grid[i, j];
            }
            catch
            {
                return false;
            }
        }
    }
}