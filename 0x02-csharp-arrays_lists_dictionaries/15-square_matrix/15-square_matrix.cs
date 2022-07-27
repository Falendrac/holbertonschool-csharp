using System;

class Matrix
{
    // computes the square value of all integers of a matrix.
    public static int[,] Square(int[,] myMatrix)
    {
        if (myMatrix == null)
            return null;

        int[,] squareMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];

        for (int x = 0; x < squareMatrix.GetLength(0); x++)
        {
            for (int y = 0; y < squareMatrix.GetLength(1); y++)
            {
                squareMatrix[x, y] = myMatrix[x, y] * myMatrix[x, y];
            }
        }

        return squareMatrix;
    }
}
