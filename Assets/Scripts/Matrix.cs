using System.Collections;
using System.Collections.Generic;

public class Matrix
{
    private int width;
    private int height;
    private double[,] matrix;

    public Matrix(int width, int height)
    {
        matrix = new double[width, height];
        this.width = width;
        this.height = height;
    }

    public Matrix(double[,] data)
    {
        matrix = data;
        this.width = data.GetLength(0);
        this.height = data.GetLength(1);
    }

    public void setMatrixField(double value, int x, int y)
    {
        if (x >= width || y >= height)
        {
            return;
        }
        matrix[x, y] = value;
    }

    public static Matrix allMatrixValue(double value, int width, int height)
    {
        Matrix m = new Matrix(width, height);
        for (int x = 0; x < m.width; x++)
        {
            for (int y = 0; y < m.height; y++)
            {
                m.setMatrixField(value, x, y);
            }
        }
        return m;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.width != m2.height)
        {
            return null;
        }
        Matrix result = new Matrix(m2.width, m1.height);
        for (int xM2 = 0; xM2 < m2.width; xM2++)
        {
            for (int yM1 = 0; yM1 < m1.height; yM1++)
            {
                double value = 0;
                for (int xM1 = 0; xM1 < m1.width; xM1++)
                {
                    value += m1.matrix[xM1, yM1] * m2.matrix[xM2, xM1];
                }
                result.setMatrixField(value, xM2, yM1);
            }
        }
        return result;
    }

    public override string ToString()
    {
        string matrixString = "";
        for (int y = 0; y < this.height; y++)
        {
            for (int x = 0; x < this.width; x++)
            {
                matrixString += matrix[x, y] + " ";
            }
            matrixString += "\n";
        }
        return matrixString;
    }
}
