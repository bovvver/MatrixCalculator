namespace MatrixCalculator
{
    internal class MatrixCalculationsHandler
    {
        public static double[,] MatrixAddition(double[,] A, double[,] B)
        {
            return MatrixSummation(A,B);
        }

        public static double[,] MatrixRemoval(double[,] A, double[,] B)
        {
            return MatrixSummation(A, B, true);
        }

        private static double[,] MatrixSummation(double[,] A, double[,] B, bool isRemoval = false)
        {
            int rowsNoA = A.GetLength(0);
            int columnsNoA = A.GetLength(1);
            int rowsNoB = B.GetLength(0);
            int columnsNoB = B.GetLength(1);

            if((rowsNoA != rowsNoB) || (columnsNoA != columnsNoB))
                throw new ArgumentException("Rows and columns are not equal.");

            double[,] result = new double[rowsNoA, columnsNoA];
            for (int i = 0; i < rowsNoA; i++)
            {
                for (int j = 0; j < columnsNoA; j++)
                {
                    if(isRemoval) result[i, j] = A[i, j] - B[i, j];
                    else result[i, j] = A[i, j] + B[i, j];
                }
            }
            return result;
        }

        public static double[,] MatrixMultiplication(double[,] A, double[,] B)
        {
            int rowsNoA = A.GetLength(0);
            int columnsNoA = A.GetLength(1);
            int rowsNoB = B.GetLength(0);
            int columnsNoB = B.GetLength(1);

            if (columnsNoA != rowsNoB)
                throw new ArgumentException("Rows and columns are not equal.");

            double[,] result = new double[rowsNoA, columnsNoB];
            double temp;

            for (int i = 0; i < rowsNoA; i++)
            {
                for (int k = 0; k < columnsNoB; k++)
                {
                    temp = 0;
                    for (int j = 0; j < columnsNoA; j++)
                        temp += A[i, j] * B[j, k];
                    result[i, k] = temp;
                }
            }
            return result;
        }

        public static double[,] MatrixScalarMultiplication(double[,] matrix, int scalar)
        {
            int rowsNo = matrix.GetLength(0);
            int columnsNo = matrix.GetLength(1);
            double[,] result = new double[rowsNo, columnsNo];

            for (int i = 0; i < rowsNo; i++)
            {
                for (int j = 0; j < columnsNo; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
    }
}
