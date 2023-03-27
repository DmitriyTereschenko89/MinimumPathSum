namespace MinimumPathSum
{
    internal class Program
    {
        public class MinimumPathSum
        {
            public int MinPathSum(int[][] grid)
            {
                int n = grid.Length;
                int m = grid[0].Length;
                int[,] dp = new int[n, m];
                for (int r = n - 1; r >= 0; --r)
                {
                    for (int c = m - 1; c >= 0; --c)
                    {
                        //if (r == n - 1 && c == m - 1)
                        //{
                        //    dp[r, c] = grid[r][c];
                        //}
                        //else if (r == n - 1)
                        //{
                        //    dp[r, c] = grid[r][c] + dp[r, c + 1];
                        //}
                        //else if (c == m - 1)
                        //{
                        //    dp[r, c] = grid[r][c] + dp[r + 1, c];
                        //}
                        //else
                        //{
                        //    dp[r, c] = Math.Min(grid[r][c] + dp[r + 1, c], grid[r][c] + dp[r, c + 1]);
                        //}
                        dp[r, c] = (r == n - 1 && c == m - 1) ? grid[r][c]
                                : r == n - 1 ? grid[r][c] + dp[r, c + 1]
                                : c == m - 1 ? grid[r][c] + dp[r + 1, c]
                                : Math.Min(grid[r][c] + dp[r + 1, c], grid[r][c] + dp[r, c + 1]);                        
                    }
                }
                return dp[0, 0];
            }
        }
        static void Main(string[] args)
        {
            MinimumPathSum minimumPathSum = new();
            Console.WriteLine(minimumPathSum.MinPathSum(new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            }));
            Console.WriteLine(minimumPathSum.MinPathSum(new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            }));
        }
    }
}