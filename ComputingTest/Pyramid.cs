namespace ConsoleApp
{
    public class PyramidMaker
    {
        public static int[][] Pyramid(int n)
        {
            int[][] output = new int[n][];
            for (int i = 0; i < n; i++)
            {
                output[i] = new int[i + 1];
                for (int x = 0; x <= i; x++)
                {
                    output[i][x] = 1;
                }
            }
            return output;
        }
        public static void Main(string[] args)
        {
            var x = Pyramid(3);
        }
    }
}
