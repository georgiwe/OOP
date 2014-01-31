using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();

        Matrix<double> matr1 = new Matrix<double>(4, 4);
        Matrix<double> matr2 = new Matrix<double>(4, 4);

        for (int row = 0; row < matr1.Rows; row++)
        {
            for (int col = 0; col < matr1.Cols; col++)
            {
                matr1[row, col] = rnd.Next(0, 10);
                matr2[row, col] = rnd.Next(0, 10);
            }
        }

        Matrix<double> resAddition = matr1 + matr2;
        Matrix<double> resSubtr = matr1 - matr2;

        if (resAddition)
        {
            Console.WriteLine("Contains non-zero elements.");
        }
        else
        {
            Console.WriteLine("Contains only zeros.");
        }
    }
}