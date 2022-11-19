// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерноcть первой матрицы: ");
Console.Write("m = ");
int numberOneMatrixOne = Convert.ToInt32(Console.ReadLine());
Console.Write("k = ");
int numberTwoMatrixOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерноcть второй матрицы: ");
Console.Write("k = ");
int numberOneMatrixTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int numberTwoMatrixTwo = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndIntFist(int rowss, int columnss)
{
    var matrixOne = new int[rowss, columnss];
    var rnd = new Random();

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = rnd.Next(10);
        }
    }
    return matrixOne;
}

int[,] CreateMatrixRndIntSecond(int rows, int columns)
{
    var matrixTwo = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = rnd.Next(10);
        }
    }
    return matrixTwo;
}

bool ExaminationMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    if ((matrixOne.GetLength(0) == matrixTwo.GetLength(1)) && (matrixOne.GetLength(1) == matrixTwo.GetLength(0))) return true;
    else return false;
}

int[,] CompositionMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    var compositionMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            compositionMatrix[i, j] = 0;

            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                compositionMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return compositionMatrix;
}


void PrintMatrixR(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("");

int[,] matrixOne = CreateMatrixRndIntFist(numberOneMatrixOne, numberTwoMatrixOne);
PrintMatrixR(matrixOne);

Console.WriteLine("");

int[,] matrixTwo = CreateMatrixRndIntSecond(numberOneMatrixTwo, numberTwoMatrixTwo);
PrintMatrixR(matrixTwo);

Console.WriteLine("");

bool examinationMatrix = ExaminationMatrix(matrixOne, matrixTwo);
if (examinationMatrix)
{
    Console.WriteLine("Произведение матриц двух матриц:");

    int[,] compositionMatrix = CompositionMatrix(matrixTwo, matrixTwo);
    PrintMatrixR(compositionMatrix);
}
else Console.WriteLine("Невозможно перемножить матрицы!");