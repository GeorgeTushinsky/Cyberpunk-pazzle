using System;

namespace Puzzle
{
    public static class ExtensionMethod
    {
        public static string[] ShaffleArray(this string[] arr)
        {
            var tmpArr = (string[])arr.Clone();
            var random = new Random();

            for (int i = 0; i < tmpArr.Length; i++)
            {
                var tmp = tmpArr[i];
                var randIndex = random.Next(0, tmpArr.Length);
                tmpArr[i] = tmpArr[randIndex];
                tmpArr[randIndex] = tmp;
            }
            return tmpArr;
        }
    }
    public class CPPuzzleMatrixGenerator
    {
        //TODO: Implement class which could generate random valid matrix for cppuzzle
        /* 
         * 1. Valid matrix means it should be solvable by rules provided in CPPuzzle
         * 2. Possibly is could have more than one solution
         */
        public int width { get; set; }
        public int height { get; set; }

        private string[] generatorCharSet = new string[] { "1C", "F7", "55", "E9", "B1" };

        public CPPuzzleMatrixGenerator(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public string[][] GenerateMatrix()
        {
            string[][] result = new string[width][];
            for (int w = 0; w < width; w++)
            {
                result[w] = generatorCharSet.ShaffleArray();
            }
            return result;
        }
    }
}
