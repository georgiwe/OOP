using System;

public class Matrix<T>
{
    private T[,] data;
    private int rows;
    private int cols;

    public Matrix(int rows, int cols)
    {
        if (rows < 0)
        {
            throw new ArgumentException("Rows count cannot be negative.");
        }

        if (cols < 0)
        {
            throw new ArgumentException("Cols count cannot be negative.");
        }

        this.data = new T[rows, cols];
        this.rows = rows;
        this.cols = cols;
    }

    public int Rows
    {
        get { return this.rows; }
    }

    public int Cols
    {
        get { return this.cols; }
    }

    public T this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= this.rows)
            {
                throw new ArgumentOutOfRangeException("Row was out of range");
            }

            if (col < 0 || row >= this.rows)
            {
                throw new ArgumentOutOfRangeException("Col was out of range");
            }

            return this.data[row, col];
        }

        set
        {
            if (row < 0 || row >= this.rows)
            {
                throw new ArgumentOutOfRangeException("Row was out of range");
            }

            if (col < 0 || row >= this.rows)
            {
                throw new ArgumentOutOfRangeException("Col was out of range");
            }

            this.data[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
    {
        if (first.Rows != second.Rows ||
            first.Cols != second.Cols)
        {
            throw new ArgumentException("The two matrices must be of identical size.");
        }

        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

        for (int i = 0; i < result.Rows; i++)
        {
            for (int j = 0; j < result.Cols; j++)
            {
                result[i, j] = (dynamic)first[i, j] + (dynamic)second[i, j];
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
    {
        if (first.Rows != second.Rows ||
            first.Cols != second.Cols)
        {
            throw new ArgumentException("The two matrices must be of identical size.");
        }

        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

        for (int i = 0; i < result.Rows; i++)
        {
            for (int j = 0; j < result.Cols; j++)
            {
                result[i, j] = (dynamic)first[i, j] - (dynamic)second[i, j];
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
    {
        if (first.Rows != second.Rows ||
            first.Cols != second.Cols)
        {
            throw new ArgumentException("The two matrices must be of identical size.");
        }

        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

        for (int i = 0; i < result.Rows; i++)
        {
            for (int j = 0; j < result.Cols; j++)
            {
                result[i, j] = (dynamic)first[i, j] * (dynamic)second[i, j];
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if ((dynamic)matrix[row, col] != 0)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if ((dynamic)matrix[row, col] != 0)
                {
                    return true;
                }
            }
        }

        return false;
    }
}