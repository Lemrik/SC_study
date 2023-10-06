namespace sc_v33
{
    // СТУПЕНЧАТЫЕ (ЗУБЧАТЫЕ) МАССИВЫ
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];
            int[,] myArray2 = new int[3,5];

            int myArrRank = myArray.Rank;
            int myArr2Rank = myArray2.Rank;

            int myArrLength = myArray.Length;
            int myArr2Length = myArray2.Length;

        }
    }
} 